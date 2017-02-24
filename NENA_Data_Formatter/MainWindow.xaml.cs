using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace _911Updater
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void clear_click(object sender, RoutedEventArgs e)
        {
            datafield.Text = string.Empty;
        }
        private void clearRes_Click(object sender, RoutedEventArgs e)
        {
            statusBox.Text = string.Empty;
        }
        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void enter_click(object sender, RoutedEventArgs e)
        {
            DateTime today = DateTime.Now;
            int dayofyear = today.DayOfYear;
            string date = dayofyear.ToString().PadLeft(3, '0');

            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = "STFA" + date + '1'; // Default file name
            dlg.AddExtension = false;
            dlg.Filter = "All Types(*.*) | *.*"; // Filter files by extension
            dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Show save file dialog box
            Nullable<bool> result = dlg.ShowDialog();

            // Process save file dialog box results
            if (result == true)
            {
                // Save document
                string outfile = dlg.FileName;

                this.datafield.Text = this.datafield.Text.TrimEnd();
                StringCollection lines = new StringCollection();
                int lineCount = datafield.LineCount;

                for (int line = 0; line < lineCount; line++)
                    lines.Add(datafield.GetLineText(line));

                foreach (string l in lines)
                {
                    // From GUI
                    string campus = l.Split((char[])null, StringSplitOptions.RemoveEmptyEntries)[0];
                    string bldg = l.Split((char[])null, StringSplitOptions.RemoveEmptyEntries)[1];
                    string roomnum = l.Split((char[])null, StringSplitOptions.RemoveEmptyEntries)[2];
                    string ext = l.Split((char[])null, StringSplitOptions.RemoveEmptyEntries)[3].Substring(1);
                    if (ext.Contains("x")) { ext.Replace("x", ""); }

                    string FuncCode = l.Split((char[])null, StringSplitOptions.RemoveEmptyEntries)[4];
                    string fcode = "";
                    if (FuncCode == "N") { fcode = "I"; }
                    else { fcode = FuncCode; }

                    string npa = "415";
                    string callnumber = "555" + ext;
                    string housenum = "";
                    string housenumsuff = "";
                    string predir = "";
                    string streetn = "";
                    string streets = "";
                    string postdir = "";
                    string commname = "";
                    string state = "CA";
                    string location = bldg + " " + roomnum;
                    string custname = "STARFLEET ACADEMY";
                    string classos = "4";
                    string typeos = "0";
                    string exch = "";
                    string esn = "";
                    string mnpa = "415";
                    string mnum = "555" + ext; ;
                    string onum = "";
                    string xdate = "";
                    string county = "";
                    string provider = "STAR";
                    string source = "";
                    string zip = "";
                    string zip4 = "";
                    string general = "";
                    string custcode = "";
                    string comm = "";
                    string xcord = "";
                    string ycord = "";
                    string zcord = "";
                    string celid = "";
                    string secid = "";
                    string tarc = "";
                    string res1 = "";
                    string altn = "";
                    string xxdate = "";
                    string nena = "";
                    string dataprov = "";
                    string res2 = "";
                    string eor = "*";
                    //End GUI

                    switch (campus)
                    {
                        case "A":
                            {
                                housenum = "000";
                                predir = "N";
                                streetn = "ASTRIS";
                                streets = "DR";
                                commname = "SAUSALITO";
                                zip = "94966";
                                tarc = "MACO";

                                csventry entry = new csventry(fcode, npa, callnumber, housenum, housenumsuff, predir, streetn, streets, postdir, commname, state,
                                    location, custname, classos, typeos, exch, esn, mnpa, mnum, onum, xdate, county, provider, source, zip, zip4, general, custcode,
                                    comm, xcord, ycord, zcord, celid, secid, tarc, res1, altn, xxdate, nena, dataprov, res2, eor);
                                statusBox.AppendText("Processed " + campus + " " + location + Environment.NewLine);
                                File.AppendAllText(outfile, entry.ToString() + Environment.NewLine);
                                break;
                            }

                        case "B":
                            {
                                housenum = "000";
                                streetn = "PHARMACON";
                                streets = "CT";
                                commname = "SAN DIEGO";
                                zip = "92140";
                                tarc = "SDCO";

                                csventry entry = new csventry(fcode, npa, callnumber, housenum, housenumsuff, predir, streetn, streets, postdir, commname, state,
                                    location, custname, classos, typeos, exch, esn, mnpa, mnum, onum, xdate, county, provider, source, zip, zip4, general, custcode,
                                    comm, xcord, ycord, zcord, celid, secid, tarc, res1, altn, xxdate, nena, dataprov, res2, eor);
                                statusBox.AppendText("Processed " + campus + " " + location + Environment.NewLine);
                                File.AppendAllText(outfile, entry.ToString() + Environment.NewLine);
                                break;
                            }

                        case "C":
                            {
                                housenum = "000";
                                streetn = "ARBITER";
                                streets = "BLVD";
                                commname = "CHOWCHILLA";
                                zip = "93610";
                                tarc = "MDCO";

                                csventry entry = new csventry(fcode, npa, callnumber, housenum, housenumsuff, predir, streetn, streets, postdir, commname, state,
                                    location, custname, classos, typeos, exch, esn, mnpa, mnum, onum, xdate, county, provider, source, zip, zip4, general, custcode, comm,
                                    xcord, ycord, zcord, celid, secid, tarc, res1, altn, xxdate, nena, dataprov, res2, eor);
                                statusBox.AppendText("Processed " + campus + " " + location + Environment.NewLine);
                                File.AppendAllText(outfile, entry.ToString() + Environment.NewLine);
                                break;
                            }
                    }
                }
            }
        }
    }
}