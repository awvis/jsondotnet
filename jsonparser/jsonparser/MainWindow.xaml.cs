using Microsoft.Win32;
using Newtonsoft.Json;
using System.Diagnostics;
using System.IO;

using System.Windows;


namespace jsonparser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Serializing a json file

            MyJsonSchema ne = new MyJsonSchema
            {
                element = new Element { key = "First_Key", value = "\"uint8\": 21", Object = new Object { key = "Second_Key", value = "\"sint32\": 1", checksum = 33525 } }


            };

            // serialize JSON to a string and then write string to a file
            File.WriteAllText(@"myjs.json", JsonConvert.SerializeObject(ne));
        }

        private void uploadjsn_Click(object sender, RoutedEventArgs e)
        {
            //uploading your json here

            // Load dialog
            OpenFileDialog Dialog = new OpenFileDialog();
            Dialog.Filter = "json file (*.json)|*.json|All files (*.*)|*.*";
            Dialog.Multiselect = false;
            if (!(bool)Dialog.ShowDialog()) return;

          
            // Creating variable for your json schema
            MyJsonSchema myjsns;

            using (StreamReader r = new StreamReader(Dialog.FileName))
            {
                JsonSerializer serializer = new JsonSerializer();
                myjsns = (MyJsonSchema)serializer.Deserialize(r, typeof(MyJsonSchema));
                Debug.WriteLine(myjsns);
  
            }
           
            Debug.WriteLine("Json loaded successfully");

        }
    }
}
