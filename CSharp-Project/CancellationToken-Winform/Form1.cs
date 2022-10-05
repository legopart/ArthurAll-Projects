using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace TimeTakes_Winform
{
    public partial class Form1 : Form
    {


        public CancellationTokenSource sourceToken = new CancellationTokenSource();

        public bool IsRun = true;

        public async Task SwitchLight() //SwitchLight(CancellationToken cancellationToken) <- SwitchLight(sourceToken.Token)
        {
            Panel[] pannels = new Panel[] { pnlLight1, pnlLight2, pnlLight3, pnlLight4 };
            while (true)
            {
                if (!IsRun) continue;
                foreach (var pannel in pannels)
                {
                    sourceToken.Token.ThrowIfCancellationRequested();
                    await Task.Run(() => { pannel.BackColor = Color.LightGoldenrodYellow; });
                    await Task.Delay(1000);
                    //sourceToken.Token.ThrowIfCancellationRequested(); //for cancel here too
                }
                foreach (var pannel in pannels)
                    pannel.BackColor = Color.Gray;
            }

        }


        public void lights()
        {
            Panel[] pannels = new Panel[] { pnlLight1, pnlLight2, pnlLight3, pnlLight4 };
            foreach (var pannel in pannels)
            {
                pannel.BackColor = Color.LightGoldenrodYellow;
            }
        }

        public Form1()
        {
            InitializeComponent();

            Task.Run(async () => {
                await SwitchLight();    //SwitchLight(sourceToken.Token)
            });
        }
        ~Form1() {
            sourceToken.Dispose();


        }


        private void btnPower_Click(object sender, EventArgs e)
        {
            IsRun = !IsRun;
        }


        private void btnAsyncPower_Click(object sender, EventArgs e)
        {
            if(IsRun && !sourceToken.IsCancellationRequested)
            {
                sourceToken.Cancel();
                IsRun = false;
            }
            else
            {

                if (sourceToken.IsCancellationRequested) 
                {
                    sourceToken.Dispose();
                    sourceToken = new CancellationTokenSource();
                }
                       
                Task.Run(async () => {
                    await SwitchLight();    //SwitchLight(sourceToken.Token)
                });
                IsRun = true;
            }
            
        }
    }
}