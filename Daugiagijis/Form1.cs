using DebugTools.Tools;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Sukuriamas ?rankis, skirtas debagavimui
            Inspector inspect = new Inspector();
        }

        // Patikrina, ar pirmoji matrica yra tinkama
        private bool IsFirstMatrixValid()
        {
            return int.TryParse(X1Input.Text, out int x1) && int.TryParse(Y1Input.Text, out int y1) && x1 > 0 && y1 > 0;
        }

        // Patikrina, ar antroji matrica yra tinkama
        private bool IsSecondMatrixValid()
        {
            return int.TryParse(X2Input.Text, out int x2) && int.TryParse(Y2Input.Text, out int y2) && x2 > 0 && y2 > 0;
        }

        // Patikrina, ar galima atlikti matric? daugyb?
        private bool IsMatrixMultiplicationValid()
        {
            // Patikrinama, ar matric? dydžiai tinkami ir ar jos gali b?ti sudaugintos
            return int.TryParse(X1Input.Text, out int x1) && int.TryParse(Y1Input.Text, out int y1) && int.TryParse(X2Input.Text, out int x2) && int.TryParse(Y2Input.Text, out int y2) && x1 > 0 && y1 > 0 && x2 > 0 && y2 > 0 && x1 == y2;
        }

        // Atvaizduoja pranešim? naudotojui
        private void DisplayMessageBox(string message)
        {
            MessageBox.Show(message);
        }

        // Inicializuoja matricos kontroliuojan?ius elementus
        private void InitializeMatrixControls(FlowLayoutPanel panel, int xSize, int ySize, string matrixName)
        {
            // Išvaloma esama turinys
            panel.Controls.Clear();

            // Sukuriama teksto lauk? eilut?, skirta matricos stulpeli? pavadinimams
            for (int i = 0; i < xSize; i++)
            {
                TextBox a = new TextBox();
                a.Size = new Size(33, 23);
                a.ReadOnly = true;
                a.BorderStyle = BorderStyle.None;
                a.TextAlign = HorizontalAlignment.Center;
                a.Text = matrixName + (i + 1).ToString();
                panel.Controls.Add(a);
                if (i + 1 == xSize)
                {
                    panel.SetFlowBreak(a, true);
                }
            }
            
            // Sukuria teksto lauk? eilut?s, skirtos matricos reikšm?ms, generavimas
            for (int i = 0; i < ySize; i++)
            {
                for (int j = 0; j < xSize; j++)
                {
                    int nameText = (i + 1) * 10 + j + 1;
                    TextBox a = new TextBox();
                    a.Size = new Size(33, 23);
                    a.Name = nameText.ToString();
                    panel.Controls.Add(a);
                    if (j + 1 == xSize)
                    {
                        panel.SetFlowBreak(a, true);
                    }
                }
            }
        }

        // ?vyksta, kai paspaudžiamas mygtukas "Generuoti"
        private void button1_Click(object sender, EventArgs e)
        {
            // Patikrinama, ar pirmoji matrica yra tinkama
            if (!IsFirstMatrixValid())
            {
                // Jei ne, rodomas pranešimas ir nutraukiama veiksmas
                DisplayMessageBox("?veskite pirmosios matricos numer?");
                return;
            }

            // Gaunami pirmosios matricos dydžiai
            int x1 = X1Input.Text.Any() ? int.Parse(X1Input.Text) : 0;
            int y1 = Y1Input.Text.Any() ? int.Parse(Y1Input.Text) : 0;

            // Patikrinama, ar antroji matrica yra tinkama
            if (!IsSecondMatrixValid())
            {
                // Jei ne, rodomas pranešimas ir nutraukiama veiksmas
                DisplayMessageBox("?veskite antrosios matricos numer?");
                return;
            }

            // Gaunami antrosios matricos dydžiai
            int x2 = X2Input.Text.Any() ? int.Parse(X2Input.Text) : 0;
            int y2 = Y2Input.Text.Any() ? int.Parse(Y2Input.Text) : 0;

            // Patikrinama, ar galima atlikti matric? daugyb?
            if (!IsMatrixMultiplicationValid())
            {
                // Jei ne, rodomas pranešimas ir nutraukiama veiksmas
                DisplayMessageBox("Matrica negali b?ti sudauginta");
                return;
            }

            // Inicializuojami pirmosios matricos kontroliuojantys elementai
            InitializeMatrixControls(flowLayoutPanelFirstMatrix, x1, y1, "A");
            // Inicializuojami antrosios matricos kontroliuojantys elementai
            InitializeMatrixControls(flowLayoutPanelSecondMatrix, x2, y2, "B");
        }

        // ?vyksta, kai paspaudžiamas mygtukas "Apskai?iuoti"
        private void Calculate_Click(object sender, EventArgs e)
        {
            // Patikrinama, ar pirmoji matrica yra tinkama
            if (!IsFirstMatrixValid())
            {
                // Jei ne, rodomas pranešimas ir nutraukiama veiksmas
                DisplayMessageBox("?veskite pirmosios matricos numer?");
                return;
            }

            // Gaunami pirmosios matricos dydžiai
            int x1 = X1Input.Text.Any() ? int.Parse(X1Input.Text) : 0;
            int y1 = Y1Input.Text.Any() ? int.Parse(Y1Input.Text) : 0;

            // Patikrinama, ar antroji matrica yra tinkama
            if (!IsSecondMatrixValid())
            {
                // Jei ne, rodomas pranešimas ir nutraukiama veiksmas
                DisplayMessageBox("?veskite antrosios matricos numer?");
                return;
            }

            // Gaunami antrosios matricos dydžiai
            int x2 = X2Input.Text.Any() ? int.Parse(X2Input.Text) : 0;
            int y2 = Y2Input.Text.Any() ? int.Parse(Y2Input.Text) : 0;

            // Patikrinama, ar galima atlikti matric? daugyb?
            if (!IsMatrixMultiplicationValid())
            {
                // Jei ne, rodomas pranešimas ir nutraukiama veiksmas
                DisplayMessageBox("Matrica negali b?ti sudauginta");
                return;
            }

            // Inicializuojami 2D masyvai skirti laikyti matricas
            int[,] FirstMatrix = new int[y1, x1];
            int[,] SecondMatrix = new int[y2, x2];

            // Pirmoji matrica konvertuojama ? 2D masyv?
            for (int i = 0; i < y1; i++)
            {
                for (int j = 0; j < x1; j++)
                {
                    string controlName = ((i + 1) * 10 + j + 1).ToString();
                    Control[] foundControls = flowLayoutPanelFirstMatrix.Controls.Find(controlName, true);
                    if (foundControls.Length > 0)
                    {
                        FirstMatrix[i, j] = int.Parse(foundControls[0].Text);
                    }
                }
            }

            // Antroji matrica konvertuojama ? 2D masyv?
            for (int i = 0; i < y2; i++)
            {
                for (int j = 0; j < x2; j++)
                {
                    string controlName = ((i + 1) * 10 + j + 1).ToString();
                    Control[] foundControls = flowLayoutPanelSecondMatrix.Controls.Find(controlName, true);
                    if (foundControls.Length > 0)
                    {
                        SecondMatrix[i, j] = int.Parse(foundControls[0].Text);
                    }
                }
            }

            // Sukuriama matric? skai?iavimo klas?
            MatricuSkaiciavimas calculator = new MatricuSkaiciavimas();
            // Atliekama matric? daugyba
            int[,] ResultMatrix = calculator.MultiplyMatrices(FirstMatrix, SecondMatrix);
            // Atvaizduojami rezultatai
            DisplayResult(ResultMatrix);
        }

        // Atvaizduoja rezultatus
        private void DisplayResult(int[,] ResultMatrix)
        {
            // Išvaloma rezultat? sritis
            flowLayoutPanelResult.Controls.Clear();

            // Sukuria teksto lauk? eilut?, skirt? rezultat? stulpeli? pavadinimams
            for (int i = 0; i < ResultMatrix.GetLength(0); i++)
            {
                TextBox a = new TextBox();
                a.Size = new Size(33, 23);
                a.ReadOnly = true;
                a.BorderStyle = BorderStyle.None;
                a.TextAlign = HorizontalAlignment.Center;
                a.Text = "C" + (i + 1).ToString();
                flowLayoutPanelResult.Controls.Add(a);
                if (i + 1 == ResultMatrix.GetLength(0))
                {
                    flowLayoutPanelResult.SetFlowBreak(a, true);
                }
            }

            // Sukuria teksto lauk? eilutes, skirtas rezultat? reikšm?ms, generavimas
            for (int i = 0; i < ResultMatrix.GetLength(1); i++)
            {
                for (int j = 0; j < ResultMatrix.GetLength(0); j++)
                {
                    int nameText = (i + 1) * 10 + j + 1;
                    TextBox a = new TextBox();
                    a.Size = new Size(33, 23);
                    a.Name = nameText.ToString();
                    a.Text = ResultMatrix[i, j].ToString();
                    a.ReadOnly = true;
                    flowLayoutPanelResult.Controls.Add(a);
                    if (j + 1 == ResultMatrix.GetLength(0))
                    {
                        flowLayoutPanelResult.SetFlowBreak(a, true);
                    }
                }
            }
        }
    }
}
