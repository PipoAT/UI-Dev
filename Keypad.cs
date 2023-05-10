namespace UIKeypad;

public partial class UIKeypad : Form
{
    Button keypadOneButton = new Button();
    Button keypadTwoButton = new Button();
    Button keypadThreeButton = new Button();
    Button keypadFourButton = new Button();
    Button keypadFiveButton = new Button();
    Button keypadSixButton = new Button();
    Button keypadSevenButton = new Button();
    Button keypadEightButton = new Button();
    Button keypadNineButton = new Button();
    Button keypadPoundButton = new Button();
    Button keypadStarButton = new Button();
    Button keypadZeroButton = new Button();

    public UIKeypad()
    {
        InitializeComponent();

        Text = "UI Keypad";                 // Overriding of the Name and Size of Form
        ClientSize = new Size(250, 300);
        MinimizeBox = false;
        MaximizeBox = false;
    

        keypadOneButton.Text = "1";                     // Establish and create the buttons of the 3*4 keypad
        keypadOneButton.TextAlign = ContentAlignment.MiddleCenter;
        keypadOneButton.Location = new Point (50, 50);
        keypadOneButton.Size = new Size(30, 30);
        keypadOneButton.ForeColor = Color.White;
        keypadOneButton.BackColor = Color.Blue;
        keypadOneButton.Click += keypadOneButton_Click!;
        Controls.Add(keypadOneButton);

        keypadTwoButton.Text = "2";
        keypadTwoButton.TextAlign = ContentAlignment.MiddleCenter;
        keypadTwoButton.Location = new Point (90, 50);
        keypadTwoButton.Size = new Size(30, 30);
        keypadTwoButton.ForeColor = Color.White;
        keypadTwoButton.BackColor = Color.Blue;
        keypadTwoButton.Click += keypadTwoButton_Click!;
        Controls.Add(keypadTwoButton);

        keypadThreeButton.Text = "3";
        keypadThreeButton.TextAlign = ContentAlignment.MiddleCenter;
        keypadThreeButton.Location = new Point (130, 50);
        keypadThreeButton.Size = new Size(30, 30);
        keypadThreeButton.ForeColor = Color.White;
        keypadThreeButton.BackColor = Color.Blue;
        keypadThreeButton.Click += keypadThreeButton_Click!;
        Controls.Add(keypadThreeButton);

        keypadFourButton.Text = "4";
        keypadFourButton.TextAlign = ContentAlignment.MiddleCenter;
        keypadFourButton.Location = new Point (50, 90);
        keypadFourButton.Size = new Size(30, 30);
        keypadFourButton.ForeColor = Color.White;
        keypadFourButton.BackColor = Color.Blue;
        keypadFourButton.Click += keypadFourButton_Click!;
        Controls.Add(keypadFourButton);


        keypadFiveButton.Text = "5";
        keypadFiveButton.TextAlign = ContentAlignment.MiddleCenter;
        keypadFiveButton.Location = new Point (90, 90);
        keypadFiveButton.Size = new Size(30, 30);
        keypadFiveButton.ForeColor = Color.White;
        keypadFiveButton.BackColor = Color.Blue;
        keypadFiveButton.Click += keypadFiveButton_Click!;
        Controls.Add(keypadFiveButton);


        keypadSixButton.Text = "6";
        keypadSixButton.TextAlign = ContentAlignment.MiddleCenter;
        keypadSixButton.Location = new Point (130, 90);
        keypadSixButton.Size = new Size(30, 30);
        keypadSixButton.ForeColor = Color.White;
        keypadSixButton.BackColor = Color.Blue;
        keypadSixButton.Click += keypadSixButton_Click!;
        Controls.Add(keypadSixButton);

        keypadSevenButton.Text = "7";
        keypadSevenButton.TextAlign = ContentAlignment.MiddleCenter;
        keypadSevenButton.Location = new Point (50, 130);
        keypadSevenButton.Size = new Size(30, 30);
        keypadSevenButton.ForeColor = Color.White;
        keypadSevenButton.BackColor = Color.Blue;
        keypadSevenButton.Click += keypadSevenButton_Click!;
        Controls.Add(keypadSevenButton);

        keypadEightButton.Text = "8";
        keypadEightButton.TextAlign = ContentAlignment.MiddleCenter;
        keypadEightButton.Location = new Point (90, 130);
        keypadEightButton.Size = new Size(30, 30);
        keypadEightButton.ForeColor = Color.White;
        keypadEightButton.BackColor = Color.Blue;
        keypadEightButton.Click += keypadEightButton_Click!;
        Controls.Add(keypadEightButton);

        keypadNineButton.Text = "9";
        keypadNineButton.TextAlign = ContentAlignment.MiddleCenter;
        keypadNineButton.Location = new Point (130, 130);
        keypadNineButton.Size = new Size(30, 30);
        keypadNineButton.ForeColor = Color.White;
        keypadNineButton.BackColor = Color.Blue;
        keypadNineButton.Click += keypadNineButton_Click!;
        Controls.Add(keypadNineButton);

        keypadStarButton.Text = "*";
        keypadStarButton.TextAlign = ContentAlignment.MiddleCenter;
        keypadStarButton.Location = new Point (50, 170);
        keypadStarButton.Size = new Size(30, 30);
        keypadStarButton.ForeColor = Color.White;
        keypadStarButton.BackColor = Color.Blue;
        keypadStarButton.Click += keypadStarButton_Click!;
        Controls.Add(keypadStarButton);

        keypadZeroButton.Text = "0";
        keypadZeroButton.TextAlign = ContentAlignment.MiddleCenter;
        keypadZeroButton.Location = new Point (90, 170);
        keypadZeroButton.Size = new Size(30, 30);
        keypadZeroButton.ForeColor = Color.White;
        keypadZeroButton.BackColor = Color.Blue;
        keypadZeroButton.Click += keypadZeroButton_Click!;
        Controls.Add(keypadZeroButton);

        keypadPoundButton.Text = "#";
        keypadPoundButton.TextAlign = ContentAlignment.MiddleCenter;
        keypadPoundButton.Location = new Point (130, 170);
        keypadPoundButton.Size = new Size(30, 30);
        keypadPoundButton.ForeColor = Color.White;
        keypadPoundButton.BackColor = Color.Blue;
        keypadPoundButton.Click += keypadPoundButton_Click!;
        Controls.Add(keypadPoundButton);

        // Create a panel to hold the buttons
        Panel keypadPanel = new Panel();
        keypadPanel.BackColor = Color.Black;
        keypadPanel.Location = new Point(40, 40);
        keypadPanel.Size = new Size(130, 170);
        keypadPanel.BorderStyle = BorderStyle.FixedSingle;
        Controls.Add(keypadPanel);

        // Adjust the z-order to ensure the panel is behind the buttons
        keypadPanel.SendToBack();

        Panel keypadPanelBorder = new Panel();
        keypadPanelBorder.BackColor = Color.Blue;
        keypadPanelBorder.Location = new Point(30, 30);
        keypadPanelBorder.Size = new Size(150, 190);
        keypadPanelBorder.BorderStyle = BorderStyle.FixedSingle;
        Controls.Add(keypadPanelBorder);

        // Adjust the z-order to ensure the panel is behind the buttons
       keypadPanelBorder.SendToBack();

    }

    // Set up the events for when the button is clicked
    private void keypadOneButton_Click(object sender, EventArgs e) {
        MessageBox.Show("1");
    }

    private void keypadTwoButton_Click(object sender, EventArgs e) {
        MessageBox.Show("2");
    }

    private void keypadThreeButton_Click(object sender, EventArgs e) {
        MessageBox.Show("3");
    }

    private void keypadFourButton_Click(object sender, EventArgs e) {
        MessageBox.Show("4");
    }

    private void keypadFiveButton_Click(object sender, EventArgs e) {
        MessageBox.Show("5");
    }

    private void keypadSixButton_Click(object sender, EventArgs e) {
        MessageBox.Show("6");
    }

    private void keypadSevenButton_Click(object sender, EventArgs e) {
        MessageBox.Show("7");
    }

    private void keypadEightButton_Click(object sender, EventArgs e) {
        MessageBox.Show("8");
    }

    private void keypadNineButton_Click(object sender, EventArgs e) {
        MessageBox.Show("9");
    }

    private void keypadZeroButton_Click(object sender, EventArgs e) {
        MessageBox.Show("0");
    }

    private void keypadPoundButton_Click(object sender, EventArgs e) {
        MessageBox.Show("#");
    }

    private void keypadStarButton_Click(object sender, EventArgs e) {
        MessageBox.Show("*");
    }
}
