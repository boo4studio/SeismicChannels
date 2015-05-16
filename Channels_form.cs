using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Channels
{
    public partial class Channels : Form
    {

        DataView SectionView = new DataView();
        int rowOfClickedSection = 0;
        int rowOfClickedTest = 0;
        string nazwaTestu = "Capacitance";
       

        public ChannelsDataContext BazaDanychSekcji = new ChannelsDataContext();
        public Channels()
        {
            InitializeComponent();
            dataGridViewResults.RowHeadersVisible = false;
            dataGridView_Sections.RowHeadersVisible = false;
            dataGridViewTests.RowHeadersVisible = false;
            dataGridViewWyniki.RowHeadersVisible = false;
         
           			
        }
        private void Channels_Load(object sender, EventArgs e)
        {
            dataGridViewTests.Visible = false;
            SectionGdridViewLoad();

        }
        private void NewTestLoading()
        {
            
            string TestsFolderPath = Properties.Settings.Default.TestsPath;
   
            OpenFileDialog newFileDialog = new OpenFileDialog();
            newFileDialog.InitialDirectory = TestsFolderPath;
            DialogResult result = newFileDialog.ShowDialog();
         
            string TestsPath = newFileDialog.FileName;

            if (TestsPath.Length > 0)     //spawdza czy plik zostal wybrany
            {
                string TestsPathFilename = System.IO.Path.GetFileName(TestsPath);
                Console.WriteLine(TestsPath);

                /*   string[] pliki = System.IO.Directory.GetFileSystemEntries(@"Z:\Projects\02_Current_Survey\ALI029214_MultiClient_SHA_Block7A_GuineaBissau\07_Survey_Wide\06_Instrument_Daily_Tests\", "*.txt");
                   foreach (string pp in pliki)
                   {
                       string ppp = System.IO.Path.GetFileName(pp);
                       if (System.Text.RegularExpressions.Regex.IsMatch(ppp, "Daily", System.Text.RegularExpressions.RegexOptions.IgnoreCase) == true)
                       {
                           Console.WriteLine(ppp);

                       }
                   }
                   */
                // Czytanie pliku z testami

                string[] words;
                string[] lines = System.IO.File.ReadAllLines(TestsPath);
                string dateString = "";
                string timeString = "";
                int FailedCapacitanceTest = 0;
                int FailedCutOffTest = 0;
                int FailedLeakageTest = 0;


                char[] delimiterChars = { ' ' };
                if (TestsPathFilename.IndexOf("D", 0, 1) == 0)
                {
                    string year = TestsPath.Substring(6, 4);
                    string month = TestsPath.Substring(10, 2);
                    string day = TestsPath.Substring(12, 2);
                    string hour = TestsPath.Substring(15, 2);
                    string minute = TestsPath.Substring(17, 2);
                    dateString = TestsPathFilename.Substring(6, 8);
                    timeString = TestsPathFilename.Substring(15, 6);
                   // dateString = year + month + day + hour + minute;
                }
                else if (TestsPathFilename.IndexOf("W", 0, 1) == 0)
                {
                    string year = TestsPath.Substring(7, 4);
                    string month = TestsPath.Substring(11, 2);
                    string day = TestsPath.Substring(13, 2);
                    string hour = TestsPath.Substring(16, 2);
                    string minute = TestsPath.Substring(18, 2);
                    dateString = TestsPathFilename.Substring(7, 8);
                    timeString = TestsPathFilename.Substring(16, 6);
                   // dateString = year + month + day + hour + minute;
                }
              
                // checking test date
                //string[] words = lines[1].Split(delimiterChars);


                var listaTestow = BazaDanychSekcji.Tests;

                var szukanyTest = from tests in listaTestow
                                  where tests.TestDate == Convert.ToInt32(dateString)
                                  select tests;

                Console.WriteLine(szukanyTest.Count());

                if (szukanyTest.Count() == 0)
                {


                    // DateTime dateTime = Convert.ToDateTime(dateString);

                    words = lines[5].Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                    string InstrDistorMax = words[2];
                    words = lines[6].Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                    string InstrCMRR = words[2];
                    words = lines[7].Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                    string InstrGainMin = words[2];
                    string InstrGainMax = words[4];
                    words = lines[8].Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                    string InstrPhaseMin = words[2];
                    string InstrPhaseMax = words[4];
                    words = lines[9].Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                    string InstrCrosstalkMin = words[2];
                    words = lines[10].Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                    string InstrNoiseMax = words[2];
                    words = lines[11].Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                    string FieldNoiseMaxS2 = words[3];
                    words = lines[12].Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                    string FieldNoiseMaxS1 = words[2];
                    words = lines[13].Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                    string FieldCapMinS2 = words[3];
                    Console.WriteLine(FieldCapMinS2);
                    string FieldCapMaxS2 = words[5];
                    words = lines[14].Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                    string FieldCapMinS1 = words[2];
                    string FieldCapMaxS1 = words[4];
                    words = lines[15].Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                    string FieldLeakageS2 = words[3];
                    words = lines[16].Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                    string FieldLeakageS1 = words[2];
                    words = lines[17].Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                    string FieldCutMinS2 = words[4];
                    string FieldCutMaxS2 = words[6];
                    words = lines[18].Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                    string FieldCutMinS1 = words[2];
                    string FieldCutMaxS1 = words[4];
                    words = lines[20].Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                    string SampleRate = words[2];
                    words = lines[21].Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                    string Gain = words[2];


                    

                    Test nowyTest = new Test
                    {
                        TestDate = Convert.ToInt32(dateString),
                        TestTime = Convert.ToInt32(timeString),
                        DistortionMax = StringConverter(InstrDistorMax),
                        DistortionMin = StringConverter(InstrDistorMax),
                        FieldCapS1Min = StringConverter(FieldCapMinS1),
                        FieldCapS2Min = StringConverter(FieldCapMinS2),
                        FieldCapS1Max = StringConverter(FieldCapMaxS1),
                        FieldCapS2Max = StringConverter(FieldCapMaxS2),
                        FieldCutS1Min = StringConverter(FieldCutMinS1),
                        FieldCutS1Max = StringConverter(FieldCutMaxS1),
                        FieldCutS2Min = StringConverter(FieldCutMinS2),
                        FieldCutS2Max = StringConverter(FieldCutMaxS2),
                        FieldNoiseS1 = StringConverter(FieldNoiseMaxS1),
                        FieldNoiseS2 = StringConverter(FieldNoiseMaxS2),
                        FieldLeakageS1 = StringConverter(FieldLeakageS1),
                        FieldLeakageS2 = StringConverter(FieldLeakageS2),
                    };

                    listaTestow.InsertOnSubmit(nowyTest);
                    BazaDanychSekcji.SubmitChanges();
                }
                else
                {
                    MessageBox.Show("There is already test from this date");
                }



                string mark = "---";
                string markcheck = " ";
                int inc = 0;


                // looking for first channel results

                while ((mark == markcheck) == false)
                {
                    markcheck = lines[28 + inc].Substring(1, 3);
                    ++inc;
                    Console.WriteLine(markcheck);
                    Console.WriteLine(inc);
                }
                markcheck = "";
                //****************************************************  Adding sections and channels to database

                while ((mark == markcheck) == false)    // a loop to last channel
                {
                   
                    object serialo;
                    int trace = 0;
                    int streamer = 0;
                    int section = 0;
                    bool foundSerial = false;
                    words = lines[32 + inc].Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                    string serial = words[4];
                    streamer = Convert.ToInt32(words[0]);
                    trace = Convert.ToInt16(words[1]);
                    section = Convert.ToInt16(words[2]);
                    int SectionChannel = trace % 12;
                    if (SectionChannel==0)
                    {
                        SectionChannel = 12;
                    }
                    string Capacitance = words[9];
                    string Cutoff = words[11];
                    string Noise = words[13];
                    string Leakage = words[15];
                    if (lines[32 + inc].ToString().IndexOf("Capacitance") > -1)
                    {
                        FailedCapacitanceTest = 1;
                    }
                    else FailedCapacitanceTest = 0;
                    if (lines[32 + inc].ToString().IndexOf("Cut") > -1)
                    {
                        FailedCutOffTest = 1;
                    }
                    else FailedCutOffTest = 0;
                    if (lines[32 + inc].ToString().IndexOf("Leakage") > -1)
                    {
                        FailedLeakageTest = 1;
                    }
                    else FailedLeakageTest = 0;
                     



                    //***********************************checking if serial is in serial table

                    
                    int? MaxChIDNumber = 1;

                    var listaRezultatow = BazaDanychSekcji.Results;
                    var wszystkieRezultaty = from results in listaRezultatow
                                             select results.CHID;
                    MaxChIDNumber = wszystkieRezultaty.Max();   // najwieksza wartosc CHID
                  
//***********************************************************************************************


                    var listaSekcji = BazaDanychSekcji.Sections;

                    var szukanaSekcja = from sections in listaSekcji
                                        where sections.Serial == Convert.ToInt16(serial)
                                        select sections;
                    if (szukanaSekcja.Count() == 0)
                    {
                        foundSerial = false;
                        Section nowaSekcja = new Section { Serial = Convert.ToInt16(serial) };
                        listaSekcji.InsertOnSubmit(nowaSekcja);
                        BazaDanychSekcji.SubmitChanges();

                    }
                    else
                    { foundSerial = true; }

//****************************************************************************************** Sections list updated

                    var listaWynikow = BazaDanychSekcji.Results;


                    Result WynikTestu = new Result { TraceNb = SectionChannel,
                                                    StreamerNb = streamer,
                                                    SerialID = Convert.ToInt16(serial),
                                                    TestID = Convert.ToInt32(dateString),
                                                    Capacitance = Convert.ToInt16(Capacitance),
                                                    CutOff = StringConverter(Cutoff),
                                                    Noise = StringConverter(Noise),
                                                    Leakage = StringConverter(Leakage),
                                                    CapacitanceFailed = FailedCapacitanceTest,
                                                    CutOffFailed = FailedCutOffTest,
                                                    LeakageFailed = FailedLeakageTest
                                                    };
                    listaWynikow.InsertOnSubmit(WynikTestu);
                    BazaDanychSekcji.SubmitChanges();

                    ++inc;
                    markcheck = lines[32 + inc].Substring(1, 3); // spawdza gdzie jest koniec listy kanalow
                    
                }
            }
//*******************************************************Creating new table
			
        }
        private void Sections_button_Click(object sender, EventArgs e)
        {
            buttonLeakage.Visible = true;
            buttonCutOff.Visible = true;
            buttonCapacitance.Visible = true;
            dataGridView_Sections.Visible = true;
            dataGridViewTests.Visible = false;
            dataGridViewWyniki.Visible = true;
            dataGridViewResults.Visible = true;
            SectionGdridViewLoad();
        }
        private void Tests_button_Click(object sender, EventArgs e)
        {
            buttonLeakage.Visible = false;
            buttonCutOff.Visible = false;
            buttonCapacitance.Visible = false;           
            dataGridView_Sections.Visible = false;
            dataGridViewTests.Visible = true;
            dataGridViewWyniki.Visible = false;
            dataGridViewResults.Visible = false;
           
            var listaTestow = BazaDanychSekcji.Tests;
            var TestySzukane = from tests in listaTestow
                               select tests;
            dataGridViewTests.DataSource = TestySzukane;
            dataGridViewTests.Columns[0].Visible = false;
        }
        private void Settings_button_Click(object sender, EventArgs e)
        {
            Settings_window settings_window = new Settings_window();
            settings_window.ShowDialog();
        }
        private void TestLoadButton_Click(object sender, EventArgs e)
        {
            NewTestLoading();

            var listaTestow = BazaDanychSekcji.Tests;
            var TestySzukane = from tests in listaTestow
                               select tests;
            dataGridViewTests.DataSource = TestySzukane;
            dataGridViewTests.Columns[0].Visible = false;
            SectionGdridViewLoad();
        }
        private decimal StringConverter(string valueString)
        {
            float valueFloat;
           if (valueString.Contains("."))
            {
                valueString = valueString.Replace(".", ",");
            }
          //  valueFloat = float.Parse(valueString, System.Globalization.CultureInfo.InvariantCulture);
           decimal valueDecimal = Convert.ToDecimal(valueString);
           double valueDouble = Convert.ToDouble(valueString);
            valueFloat = Convert.ToSingle(valueString);
            return (valueDecimal);
        }
        private void dataGridView_Sections_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridViewResults.SelectedRows.
           
            rowOfClickedSection = e.RowIndex;
            UpdateWynikiGridView(nazwaTestu);
        }
        private void SearchSection_TextChanged(object sender, EventArgs e)
        {
            SectionView.RowFilter = "Serial like '%" + SearchSection.Text + "%'";
        }
        private void SectionGdridViewLoad()
        {
            
            DataSet SectionsSet = new DataSet();
            DataRow nowaSekcja;

            SectionsSet.Tables.Add("Sekcje");
            SectionsSet.Tables["Sekcje"].Columns.Add("Serial");

            var listaSekcji = BazaDanychSekcji.Sections;

            var sekcjeSzukane = from sections in listaSekcji
                                orderby sections.Serial
                                select sections.Serial;

            foreach (int sekcja in sekcjeSzukane)
            {
                nowaSekcja = SectionsSet.Tables["Sekcje"].NewRow();
                nowaSekcja[0] = sekcja;
                SectionsSet.Tables["Sekcje"].Rows.Add(nowaSekcja);
            }
            SectionView.Table = SectionsSet.Tables["Sekcje"];

            dataGridView_Sections.DataSource = SectionView;
            dataGridView_Sections.Columns["Serial"].Width = 215;
        }
        private void TestGridViewLoad()
        {

        }

        private void buttonCapacitance_Click(object sender, EventArgs e)
        {
            if (rowOfClickedSection==0)
            {
                MessageBox.Show("Click a section");
            }
            else
            {
                buttonCapacitance.BackColor = Color.Yellow;
                buttonCutOff.BackColor = Color.WhiteSmoke;
                buttonLeakage.BackColor = Color.WhiteSmoke;
                nazwaTestu = buttonCapacitance.Text;
                UpdateWynikiGridView(nazwaTestu);
            }

        }
        private void buttonCutOff_Click(object sender, EventArgs e)
        {
            if (rowOfClickedSection == 0)
            {
                MessageBox.Show("Click a section");
            }
            else
            {
                buttonCapacitance.BackColor = Color.WhiteSmoke;
                buttonCutOff.BackColor = Color.Yellow;
                buttonLeakage.BackColor = Color.WhiteSmoke;
                nazwaTestu = buttonCutOff.Text;
                UpdateWynikiGridView(nazwaTestu);
            }
        }
        private void buttonLeakage_Click(object sender, EventArgs e)
        {
            if (rowOfClickedSection == 0)
            {
                MessageBox.Show("Click a section");
            }
            else
            {
                buttonCapacitance.BackColor = Color.WhiteSmoke;
                buttonCutOff.BackColor = Color.WhiteSmoke;
                buttonLeakage.BackColor = Color.Yellow;
                nazwaTestu = buttonLeakage.Text;
                UpdateWynikiGridView(nazwaTestu);
            }
        }

        private void UpdateWynikiGridView (string nazwaTestu)
        {
            bool foundSerial = false;
            decimal? wyborTestu=0;


            if (rowOfClickedSection > -1)
            {
                string sekcja = dataGridView_Sections.Rows[rowOfClickedSection].Cells[0].Value.ToString();
                var wynikiDlaSekcji = BazaDanychSekcji.Results;
                var szukanaSekcja = from results in wynikiDlaSekcji
                                    where results.SerialID == Convert.ToInt16(sekcja)
                                    select results;
                var listaTestowSekcji = from results in wynikiDlaSekcji.AsEnumerable()
                                        where results.SerialID == Convert.ToInt16(sekcja)
                                        select results.TestID;
                dataGridViewResults.DataSource = szukanaSekcja;
                dataGridViewResults.Columns[0].Visible = false;
                dataGridViewResults.Columns[1].Visible = false;
                int iloscTestowDlaSekcji = listaTestowSekcji.Distinct().Count();
                DataSet ds = new DataSet("WynikiTabele");
                ds.Tables.Add(nazwaTestu);
                ds.Tables[nazwaTestu].Columns.Add("Test");
                ds.Tables[nazwaTestu].Columns.Add("Ch 1");
                ds.Tables[nazwaTestu].Columns.Add("Ch 2");
                ds.Tables[nazwaTestu].Columns.Add("Ch 3");
                ds.Tables[nazwaTestu].Columns.Add("Ch 4");
                ds.Tables[nazwaTestu].Columns.Add("Ch 5");
                ds.Tables[nazwaTestu].Columns.Add("Ch 6");
                ds.Tables[nazwaTestu].Columns.Add("Ch 7");
                ds.Tables[nazwaTestu].Columns.Add("Ch 8");
                ds.Tables[nazwaTestu].Columns.Add("Ch 9");
                ds.Tables[nazwaTestu].Columns.Add("Ch 10");
                ds.Tables[nazwaTestu].Columns.Add("Ch 11");
                ds.Tables[nazwaTestu].Columns.Add("Ch 12");

                for (int i = 1; i == iloscTestowDlaSekcji; ++i)
                {

                }
                // sprawdzamy kazdy test dla wuszukanego Serial

                DataRow nowyTest;

                foreach (Result result in szukanaSekcja)
                {
                   switch (nazwaTestu)
                        {
                            case "Capacitance": wyborTestu = result.Capacitance; break;
                            case "Cut Off": wyborTestu = result.CutOff; break;
                            case "Leakage": wyborTestu = result.Leakage; break;
                            default: break;

                        }


                    int maxRows = ds.Tables[nazwaTestu].Rows.Count;  // ilosc wynikow tabeli 
                    int i = 0;

                    if (maxRows == 0)
                    {
                        nowyTest = ds.Tables[nazwaTestu].NewRow();
                        nowyTest[0] = result.TestID;
                        ds.Tables[nazwaTestu].Rows.Add(nowyTest);
                        int channelNumber = result.TraceNb.Value;
                        nowyTest[channelNumber] = wyborTestu;
                        ds.Tables[nazwaTestu].AcceptChanges();
                    }
                    else
                    {
                        for (i = 0; i < maxRows; i++)
                        {
                            nowyTest = ds.Tables[nazwaTestu].Rows[i];

                            if (result.TestID == Convert.ToInt32(nowyTest.ItemArray.GetValue(0).ToString()))
                            {
                                foundSerial = true;
                                int channelNumber = result.TraceNb.Value;
                                nowyTest[channelNumber] = wyborTestu;
                                ds.Tables[nazwaTestu].AcceptChanges();
                            }
                            else
                            {
                                foundSerial = false;
                            }
                        }
                        if (foundSerial == false)
                        {
                            nowyTest = ds.Tables[nazwaTestu].NewRow();
                            nowyTest[0] = result.TestID;
                            ds.Tables[nazwaTestu].Rows.Add(nowyTest);
                            //i++;
                            int channelNumber = result.TraceNb.Value;
                            nowyTest[channelNumber] = wyborTestu;
                            ds.Tables[nazwaTestu].AcceptChanges();
                        }
                    }
                    // trzeba dodac wartosc dla kazdego testu/ trzeba sprawdzic jaki to Channel?
                    //po utworzeniu Test Row                
                }
                dataGridViewWyniki.DataSource = ds.Tables[nazwaTestu];
                dataGridViewWyniki.Columns["Ch 1"].Width = 70;
                dataGridViewWyniki.Columns["Ch 2"].Width = 70;
                dataGridViewWyniki.Columns["Ch 3"].Width = 70;
                dataGridViewWyniki.Columns["Ch 4"].Width = 70;
                dataGridViewWyniki.Columns["Ch 5"].Width = 70;
                dataGridViewWyniki.Columns["Ch 6"].Width = 70;
                dataGridViewWyniki.Columns["Ch 7"].Width = 70;
                dataGridViewWyniki.Columns["Ch 8"].Width = 70;
                dataGridViewWyniki.Columns["Ch 9"].Width = 70;
                dataGridViewWyniki.Columns["Ch 10"].Width = 70;
                dataGridViewWyniki.Columns["Ch 11"].Width = 70;
                dataGridViewWyniki.Columns["Ch 12"].Width = 70;
            }
        }

        private void dataGridViewWyniki_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowOfClickedTest = e.RowIndex;
            decimal? nazwaLimituMin = 0;
            decimal? nazwaLimituMax = 0;
           
            Int32 testDate = Convert.ToInt32(dataGridViewWyniki.Rows[rowOfClickedTest].Cells[0].Value.ToString());
            var listaTestow = BazaDanychSekcji.Tests;
            var TestySzukane = from tests in listaTestow
                               where tests.TestDate == testDate
                               select tests;

           

            foreach (Test test in TestySzukane)
            {
                switch (nazwaTestu)
                {
                    case "Capacitance": nazwaLimituMin = test.FieldCapS1Min; 
                                        nazwaLimituMax = test.FieldCapS1Max;
                                        LimityLabel.Text = "Capacitance LimitMin : "+nazwaLimituMin.ToString()+" nF    LimitMax : "+nazwaLimituMax.ToString()+" nF" ;
                                        break;
                    case "Cut Off": nazwaLimituMin = test.FieldCutS1Min; 
                                    nazwaLimituMax = test.FieldCutS1Max;
                                    LimityLabel.Text = "Cut Off LimitMin : " + nazwaLimituMin.ToString() + " Hz    LimitMax : " + nazwaLimituMax.ToString() + " Hz";
                                    break;
                    case "Leakage": nazwaLimituMax = test.FieldLeakageS1;
                                    LimityLabel.Text = "Leakage LimitMax : " + nazwaLimituMax.ToString() + " mOhm";
                                    break;
                    default: break;
                }
                
            }
           // LimityLabel.Text = nazwaLimituMax.ToString();
        }
    }

}
