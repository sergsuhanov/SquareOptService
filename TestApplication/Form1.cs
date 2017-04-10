using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApplication {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        string companyCode = "test service";
        //string uri = "http://localhost:2555/SquareOptService.svc";
        string uri = "http://localhost/Opt/SquareOptService.svc";
        //string uri = "http://193.242.148.147:1199/Opt/SquareOptService.svc";

        ServiceReference1.SquareOptServiceClient getClient() {
            var timeSpan = new TimeSpan(0, 30, 0);
     
            var binding = new BasicHttpBinding();
            binding.Name = "BasicHttpBinding_IService";
            binding.ReceiveTimeout = timeSpan;
            binding.SendTimeout = timeSpan;
            binding.ReaderQuotas.MaxArrayLength = Int32.MaxValue;
            binding.MaxReceivedMessageSize = Int32.MaxValue;
            /*
            binding.MaxBufferSize = 2147483600;
            binding.MaxBufferPoolSize = 2147483600;
            binding.MaxReceivedMessageSize = 2147483600;
            binding.ReaderQuotas.MaxBytesPerRead = 2147483600;
            binding.ReaderQuotas.MaxDepth = 2147483600;
            binding.ReaderQuotas.MaxNameTableCharCount = 2147483600;
            binding.ReaderQuotas.MaxStringContentLength = 2147483600;
            */
            var address = new EndpointAddress(uri);

            var client = new ServiceReference1.SquareOptServiceClient(binding, address);
            return client;
        }

        int getId() {
            return ((TestApplication.ServiceReference1.Document)bindingSource.Current).Id;
        }

        void refresh(ServiceReference1.SquareOptServiceClient client) {
            var docs = client.GetHeaders(companyCode, new DateTime(2017, 01, 01), DateTime.Now);
            bindingSource.DataSource = docs;
        }



        private void button1_Click(object sender, EventArgs e) {
            var client = getClient();
            var doc = client.Add(companyCode);
            refresh(client);
        }


        private void button2_Click(object sender, EventArgs e) {
            var client = getClient();
            var doc = client.Load(companyCode, getId());
            random(doc);
            client.Save(companyCode, doc);
            refresh(client);
        }

        private void random(ServiceReference1.Document doc) {
            var rnd = new Random();
            doc.Description = "random";
            doc.CutDepth = ServiceReference1.CutDepth.Max;
            doc.MaxLenCuttingX = 9999;
            doc.MaxLenCuttingY = 9999;

            var plates = new List<ServiceReference1.Plate>();
            for (int i = 1; i < rnd.Next(4, 10); i++) {
                var a = new ServiceReference1.Plate() {
                    NumPos = i,
                    Width = rnd.Next(400, 2000),
                    Height = rnd.Next(400, 2000),
                    Qu = rnd.Next(1, 5),
                    Description = "m-" + i.ToString(),
                    Priority = 0
                };
                plates.Add(a);
            }
            doc.Plates = plates.ToArray();

            var dest = new List<ServiceReference1.Destination>();
            for (int i = 1; i < rnd.Next(4, 10); i++) {
                var a = new ServiceReference1.Destination() {
                    NumPos = 1,
                    Width = rnd.Next(3000, 4000),
                    Height = rnd.Next(2000, 3000),
                    Qu = rnd.Next(1, 10),
                    B = 15,
                    L = 15,
                    R = 15,
                    T = 15,
                    dCut = 15,
                    WorkHeight = 200,
                    WorkWidth = 200,
                    CarryOverWidth = 200,
                    IsRequared = false
                };
                dest.Add(a);
            }
            doc.Destinations = dest.ToArray();

        }

        private void button3_Click(object sender, EventArgs e) {
            var client = getClient();
            var result = client.Optimize(companyCode, getId());
            refresh(client);
        }

        private void button4_Click(object sender, EventArgs e) {
            var client = getClient();
            refresh(client);
        }


        private void button5_Click(object sender, EventArgs e) {
            var client = getClient();
            var doc = client.Load(companyCode, getId());

            var form  = new Form2(doc);
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e) {
            var client = getClient();
            var result = client.Export(companyCode, getId(), ServiceReference1.ExportMode.DefaultReportPdf, String.Empty);
            if (result != null) {
                SaveFileDialog ofd = new SaveFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK) {
                    System.IO.File.WriteAllBytes(ofd.FileName, result);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e) {
            var client = getClient();
            client.Delete(companyCode, getId());
            refresh(client);

        }

        class ExportArgs {
            public string Description { get; set; }
            public string Article { get; set; }
            public int Thickness { get; set; }
        }

        private void button7_Click(object sender, EventArgs e) {
            //@"{"Description":"4 mm","Article":"4","Thickness":4}";
            var parameters = System.Web.Helpers.Json.Encode(new ExportArgs() { Article = "4", Description = "4 mm", Thickness = 4 });

            var client = getClient();
            var result = client.Export(companyCode, getId(), ServiceReference1.ExportMode.Hegla, parameters);
            if (result != null) {
                SaveFileDialog ofd = new SaveFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK) {
                    System.IO.File.WriteAllBytes(ofd.FileName, result);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e) {
            //@"{"Description":"4 mm","Article":"4","Thickness":4}";
            var parameters = System.Web.Helpers.Json.Encode(new ExportArgs() { Article = "4", Description = "4 mm", Thickness = 4 });

            var client = getClient();
            var result = client.Export(companyCode, getId(), ServiceReference1.ExportMode.Intermac, parameters);
            if (result != null) {
                SaveFileDialog ofd = new SaveFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK) {
                    System.IO.File.WriteAllBytes(ofd.FileName, result);
                }
            }
        }
    }
}
