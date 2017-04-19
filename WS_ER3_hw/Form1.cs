using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WS_ER3_hw.hw;


namespace WS_ER3_hw
{
    public partial class Form1 : Form
    {
        public WS_ER3_hw.WebService_ZHELLOWORLD.Z_HELLO_WORLD_2 tt;
        public pl.aquael.er3.Z_HELLO_WORLD_2 tt2;



        public Z_DMS.Z_DMS wsdms;
        public Z_DMS.ZMB_DICTIONARY_COMPANYS fn = new Z_DMS.ZMB_DICTIONARY_COMPANYS();
        public Form1()
        {
            InitializeComponent();
            //tt = new WebService_ZHELLOWORLD.
            tt2 = new pl.aquael.er3.Z_HELLO_WORLD_2();
            tt2.Credentials = new NetworkCredential("admnet", "Bosman,1972");

            wsdms = new Z_DMS.Z_DMS();

            wsdms.Credentials= new NetworkCredential("admnet", "Pysiek,1972");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var test =tt2.Z_HELLO_WORLD(new pl.aquael.er3.Z_HELLO_WORLD());
            System.Diagnostics.Debug.WriteLine(test.RESULT.ToString());



        }

        private void button2_Click(object sender, EventArgs e)
        {
            var test1 = wsdms.ZMB_DICTIONARY_COMPANYS(new Z_DMS.ZMB_DICTIONARY_COMPANYS());
            System.Diagnostics.Debug.WriteLine(test1.RESULT.ToString());
            Z_DMS.ZMB_S_DICTIONARY_VAT parvat = new Z_DMS.ZMB_S_DICTIONARY_VAT
            {
                ALAND = "",
                KONWA = "",
                KBETR = 10,
                KNUMH = "",
                KSCHL = "",
                MWSKZ = ""
            };
            var test2 = wsdms.ZMB_DICTIONARY_VAT(new Z_DMS.ZMB_DICTIONARY_VAT { ALAND ="",})
            
        }
    }
}
