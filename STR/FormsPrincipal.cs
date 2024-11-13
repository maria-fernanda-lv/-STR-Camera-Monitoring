using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Media;

namespace STR
{
    public partial class FormsPrincipal : Form
    {
        //Variáveis e threads
        private Thread monitorThread;
        private string lastLine = string.Empty;
        private bool stopMonitoring = false;
        private string logFilePath = @"C:\Users\mlope\OneDrive\Documentos\[STR] Camera Monitoring\alert_log.txt";  //Caminho do arquivo log
        


        //Um "dicionário" para entender qual câmera está conectada em cada lugar
        private Dictionary<int, string> cameraLocations = new Dictionary<int, string>
        {
            { 1, "Quarto" },
            { 2, "Varanda" },
            { 3, "Sala" }
        };

        public FormsPrincipal()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;  //Para permitir que outras threads acessem a UI
            StartMonitoringThread();
            InitializeListView();
        }

        private void StartMonitoringThread()
        {
            //Inicializa e inicia a thread para monitoramento do log
            stopMonitoring = false;
            monitorThread = new Thread(MonitorLogFile) { IsBackground = true };
            monitorThread.Start();
        }

        private void InitializeListView()
        {
            //Colunas da ListView com dados importantes do monitoramento
            listViewAlerts.View = View.Details;
            listViewAlerts.Columns.Add("Alerta", 100, HorizontalAlignment.Left);
            listViewAlerts.Columns.Add("Câmera", 70, HorizontalAlignment.Left);
            listViewAlerts.Columns.Add("Localização", 100, HorizontalAlignment.Left);
            listViewAlerts.Columns.Add("Timestamp", 150, HorizontalAlignment.Left);

            //Quais os ícones iremos utilizar para a listagem
            imageListIcons.Images.Add("WarningIcon", SystemIcons.Warning); 
            imageListIcons.Images.Add("ErrorIcon", SystemIcons.Error);
            imageListIcons.Images.Add("InformationIcon", SystemIcons.Information);
            listViewAlerts.SmallImageList = imageListIcons;
        }

        private void MonitorLogFile()
        {
            string lastLine = string.Empty;
            
            if(File.ReadLines(logFilePath).Any()) //se houver algo escrito no log
            {
                lastLine = File.ReadLines(logFilePath).Last(); //Lê a última linha do Log
                string timestamp = ExtractTimestamp(lastLine);
                last_updated.Text = $" {timestamp}";
            }
            
            while (!stopMonitoring)
            {
                try
                {
                    if (File.Exists(logFilePath))
                    {
                        string currentLastLine = File.ReadLines(logFilePath).Last(); //Lê sempre apenas a última linha do LOG

                        if (currentLastLine != lastLine) //verifica a diferença entre a última linha lida e a última linha salva
                        {
                            lastLine = currentLastLine;
                            UpdateUI(lastLine); //Atualzia a interface
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR:" + ex.Message); //Apresentar erro caso não conseguir ler o arquivo
                }

                //Delay de 0.5 segundos
                Thread.Sleep(500);
            }
        }

        private void UpdateUI(string logEntry)
        {
            //Invoca a atualização da UI a partir da thread principal
            this.Invoke(new Action(() =>
            {
                //Extrai o timestamp, atualiza a "Última Atualização"
                string timestamp = ExtractTimestamp(logEntry);
                last_updated.Text = $" {timestamp}";
                //Identifica qual a câmera
                int cameraId = ExtractCameraId(logEntry);
                string location = cameraLocations.ContainsKey(cameraId) ? cameraLocations[cameraId] : "Local desconhecido";
                int statusId = 0;

                //Verifica o tipo de alerta e atualiza a interface. Cada tipo de informação do LOG possui seu statusID
                if (logEntry.Contains("Alerta invasor"))
                {
                    statusId = 4; //INVASOR
                    UpdateCameraIndicator(cameraId, statusId);
                    AddAlertToListView(cameraId, location, timestamp, statusId);
                    SystemSounds.Exclamation.Play();
                    ResetCameraStatus(cameraId); //Função para resetar a câmera devido a possíveis falhas de detecção. Aqui, a câmera volta a ser apenas "Conectada" depois de 10 segundos

                }
                else if (logEntry.Contains("Câmera conectada"))
                {
                    statusId = 5; //CONECTADO
                    UpdateCameraIndicator(cameraId, statusId);
                    AddAlertToListView(cameraId, location, timestamp, statusId);
                }
                else if (logEntry.Contains("Câmera não conectada"))
                {
                    statusId = 6; //FALHA DE CONEXÃO
                    UpdateCameraIndicator(cameraId, statusId);
                    AddAlertToListView(cameraId, location, timestamp, statusId);
                    SystemSounds.Exclamation.Play();
                }
                else if (logEntry.Contains("ERROR"))
                {
                    statusId = 7; //Erro de conexão
                    UpdateCameraIndicator(cameraId, statusId);
                    AddAlertToListView(cameraId, location, timestamp, statusId);
                    SystemSounds.Exclamation.Play();
                }
            }));
        }

        private void ResetCameraStatus(int cameraId)
        {
            new Thread(() =>
            {
                Thread.Sleep(30000); // Aguardar 30 segundos

                // Atualiza o status da câmera para "conectada" na thread principal
                this.Invoke(new Action(() =>
                {
                    // Atualiza o indicador da câmera para "Conectado"
                    UpdateCameraIndicator(cameraId, 5); // statusId = 5 significa "Conectado"
                }));
            }).Start();
        }

        //Atualiza a ListView
        private void AddAlertToListView(int cameraId, string location, string timestamp, int statusId)
        {
            ListViewItem item;
            //Identifica o tipo de alerta e determina um ícone necessário
            switch (statusId)
            {
                case 4:
                    item = new ListViewItem("ALERTA", "ErrorIcon");
                    break;
                case 5:
                    item = new ListViewItem("INFO", "InformationIcon");
                    break;
                case 6:
                    item = new ListViewItem("ALERTA", "WarningIcon");
                    break;
                default:
                    item = new ListViewItem("ALERTA", "WarningIcon");
                    break;
            }


            item.SubItems.Add($"Câmera {cameraId}");
            item.SubItems.Add(location);
            item.SubItems.Add(timestamp);

            //Adiciona linha na listview
            listViewAlerts.Items.Add(item);
        }

        private string ExtractTimestamp(string logEntry)
        {
            //Extrai o timestamp do log  como a primeira parte da string daquela linha
            string timestamp = logEntry.Split(' ')[0] + " " + logEntry.Split(' ')[1];
            return timestamp;
        }

        private int ExtractCameraId(string logEntry)
        {
            //Extrai ID da Câmera no LOG
            string cameraIdText = logEntry.Substring(logEntry.IndexOf("Câmera: ") + "Câmera: ".Length);
            cameraIdText = cameraIdText.Split(',')[0].Trim(); // Pega o valor até a próxima vírgula
            return int.Parse(cameraIdText);
        }

        private void UpdateCameraIndicator(int cameraId, int statusId)
        {
            //Identifica qual câmera atualizar
            Panel cameraPanel = this.Controls.Find($"camera{cameraId}", true).FirstOrDefault() as Panel;
            // Atualiza o Label correspondente ao ID da câmera
            Label cameraLabel = this.Controls.Find($"label_{cameraId}", true).FirstOrDefault() as Label;

            if (statusId == 4) //Caso de Invasor detectado
            {
                cameraPanel.BackColor = Color.Red;  
                cameraPanel.Refresh();
                cameraLabel.Text = $"Câmera {cameraId} - Alerta de invasor";
                cameraLabel.BackColor = Color.Red;  
                cameraLabel.Refresh(); 
            }


            if (statusId == 5) //Caso de câmera conectada
            {
                cameraPanel.BackColor = Color.PaleGreen;
                cameraPanel.Refresh();
                cameraLabel.Text = $"Conectada";
                cameraLabel.BackColor = Color.PaleGreen;  
                cameraLabel.Refresh(); 
            }

            if (statusId == 6) //Caso de falha na câmera
            {
                cameraPanel.BackColor = Color.Gold;
                cameraPanel.Refresh();
                cameraLabel.Text = $"Erro na Câmera";
                cameraLabel.BackColor = Color.Gold;  
                cameraLabel.Refresh(); 
            }

            if (statusId == 7) //Caso de erro de conexão
            {
                MessageBox.Show("Verifique conexão com as câmeras. Erro de conexão.", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Encerra a thread de monitoramento ao fechar o formulário
            stopMonitoring = true;
            monitorThread.Join();  // Espera a thread finalizar
            base.OnFormClosing(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void listViewAlerts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
