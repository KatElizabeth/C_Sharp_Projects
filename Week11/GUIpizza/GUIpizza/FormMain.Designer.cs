namespace GUIpizza
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.gbxToppings = new System.Windows.Forms.GroupBox();
            this.chkProsciutto = new System.Windows.Forms.CheckBox();
            this.chkBacon = new System.Windows.Forms.CheckBox();
            this.chkSalami = new System.Windows.Forms.CheckBox();
            this.chkSausage = new System.Windows.Forms.CheckBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkOnions = new System.Windows.Forms.CheckBox();
            this.chkPineapple = new System.Windows.Forms.CheckBox();
            this.chkBlackOlives = new System.Windows.Forms.CheckBox();
            this.chkCheese = new System.Windows.Forms.CheckBox();
            this.gbxDining = new System.Windows.Forms.GroupBox();
            this.radTakeOut = new System.Windows.Forms.RadioButton();
            this.radDelivery = new System.Windows.Forms.RadioButton();
            this.radDineIn = new System.Windows.Forms.RadioButton();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.radThin = new System.Windows.Forms.RadioButton();
            this.radTraditional = new System.Windows.Forms.RadioButton();
            this.radDeepDish = new System.Windows.Forms.RadioButton();
            this.radStuffedCrust = new System.Windows.Forms.RadioButton();
            this.gbxCrust = new System.Windows.Forms.GroupBox();
            this.lblStuffed = new System.Windows.Forms.Label();
            this.lblDeep = new System.Windows.Forms.Label();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCalculator = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxDrinks = new System.Windows.Forms.GroupBox();
            this.chkSprite = new System.Windows.Forms.CheckBox();
            this.chkRootBeer = new System.Windows.Forms.CheckBox();
            this.chkCoke = new System.Windows.Forms.CheckBox();
            this.chkDietCoke = new System.Windows.Forms.CheckBox();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.btnUpdatePrice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbxOpenSign = new System.Windows.Forms.PictureBox();
            this.tmrBlink = new System.Windows.Forms.Timer(this.components);
            this.gbxTip = new System.Windows.Forms.GroupBox();
            this.radBtnTipNo = new System.Windows.Forms.RadioButton();
            this.radBtnTip20 = new System.Windows.Forms.RadioButton();
            this.radBtnTip15 = new System.Windows.Forms.RadioButton();
            this.radBtnTip10 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTaxes = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblFinalPrice = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.gbxToppings.SuspendLayout();
            this.gbxDining.SuspendLayout();
            this.gbxCrust.SuspendLayout();
            this.mnuMenu.SuspendLayout();
            this.gbxDrinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOpenSign)).BeginInit();
            this.gbxTip.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxToppings
            // 
            this.gbxToppings.Controls.Add(this.chkProsciutto);
            this.gbxToppings.Controls.Add(this.chkBacon);
            this.gbxToppings.Controls.Add(this.chkSalami);
            this.gbxToppings.Controls.Add(this.chkSausage);
            this.gbxToppings.Controls.Add(this.chkPepperoni);
            this.gbxToppings.Controls.Add(this.chkGreenPeppers);
            this.gbxToppings.Controls.Add(this.chkOnions);
            this.gbxToppings.Controls.Add(this.chkPineapple);
            this.gbxToppings.Controls.Add(this.chkBlackOlives);
            this.gbxToppings.Controls.Add(this.chkCheese);
            this.gbxToppings.ForeColor = System.Drawing.SystemColors.Control;
            this.gbxToppings.Location = new System.Drawing.Point(291, 143);
            this.gbxToppings.Name = "gbxToppings";
            this.gbxToppings.Size = new System.Drawing.Size(261, 193);
            this.gbxToppings.TabIndex = 1;
            this.gbxToppings.TabStop = false;
            this.gbxToppings.Text = "Toppings - $1 each topping";
            // 
            // chkProsciutto
            // 
            this.chkProsciutto.AutoSize = true;
            this.chkProsciutto.Location = new System.Drawing.Point(148, 154);
            this.chkProsciutto.Name = "chkProsciutto";
            this.chkProsciutto.Size = new System.Drawing.Size(90, 21);
            this.chkProsciutto.TabIndex = 9;
            this.chkProsciutto.Text = "Prosciutto";
            this.chkProsciutto.UseVisualStyleBackColor = true;
            // 
            // chkBacon
            // 
            this.chkBacon.AutoSize = true;
            this.chkBacon.Location = new System.Drawing.Point(148, 126);
            this.chkBacon.Name = "chkBacon";
            this.chkBacon.Size = new System.Drawing.Size(64, 21);
            this.chkBacon.TabIndex = 8;
            this.chkBacon.Text = "Bacon";
            this.chkBacon.UseVisualStyleBackColor = true;
            // 
            // chkSalami
            // 
            this.chkSalami.AutoSize = true;
            this.chkSalami.Location = new System.Drawing.Point(148, 99);
            this.chkSalami.Name = "chkSalami";
            this.chkSalami.Size = new System.Drawing.Size(68, 21);
            this.chkSalami.TabIndex = 7;
            this.chkSalami.Text = "Salami";
            this.chkSalami.UseVisualStyleBackColor = true;
            // 
            // chkSausage
            // 
            this.chkSausage.AutoSize = true;
            this.chkSausage.Location = new System.Drawing.Point(148, 71);
            this.chkSausage.Name = "chkSausage";
            this.chkSausage.Size = new System.Drawing.Size(77, 21);
            this.chkSausage.TabIndex = 6;
            this.chkSausage.Text = "Sausage";
            this.chkSausage.UseVisualStyleBackColor = true;
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Location = new System.Drawing.Point(148, 45);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(90, 21);
            this.chkPepperoni.TabIndex = 5;
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Location = new System.Drawing.Point(6, 154);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(116, 21);
            this.chkGreenPeppers.TabIndex = 4;
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            // 
            // chkOnions
            // 
            this.chkOnions.AutoSize = true;
            this.chkOnions.Location = new System.Drawing.Point(6, 126);
            this.chkOnions.Name = "chkOnions";
            this.chkOnions.Size = new System.Drawing.Size(71, 21);
            this.chkOnions.TabIndex = 3;
            this.chkOnions.Text = "Onions";
            this.chkOnions.UseVisualStyleBackColor = true;
            // 
            // chkPineapple
            // 
            this.chkPineapple.AutoSize = true;
            this.chkPineapple.Location = new System.Drawing.Point(6, 99);
            this.chkPineapple.Name = "chkPineapple";
            this.chkPineapple.Size = new System.Drawing.Size(88, 21);
            this.chkPineapple.TabIndex = 2;
            this.chkPineapple.Text = "Pineapple";
            this.chkPineapple.UseVisualStyleBackColor = true;
            // 
            // chkBlackOlives
            // 
            this.chkBlackOlives.AutoSize = true;
            this.chkBlackOlives.Location = new System.Drawing.Point(6, 71);
            this.chkBlackOlives.Name = "chkBlackOlives";
            this.chkBlackOlives.Size = new System.Drawing.Size(101, 21);
            this.chkBlackOlives.TabIndex = 1;
            this.chkBlackOlives.Text = "Black Olives";
            this.chkBlackOlives.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            this.chkCheese.AutoSize = true;
            this.chkCheese.Location = new System.Drawing.Point(6, 44);
            this.chkCheese.Name = "chkCheese";
            this.chkCheese.Size = new System.Drawing.Size(105, 21);
            this.chkCheese.TabIndex = 0;
            this.chkCheese.Text = "Extra Cheese";
            this.chkCheese.UseVisualStyleBackColor = true;
            // 
            // gbxDining
            // 
            this.gbxDining.Controls.Add(this.radTakeOut);
            this.gbxDining.Controls.Add(this.radDelivery);
            this.gbxDining.Controls.Add(this.radDineIn);
            this.gbxDining.ForeColor = System.Drawing.SystemColors.Control;
            this.gbxDining.Location = new System.Drawing.Point(558, 143);
            this.gbxDining.Name = "gbxDining";
            this.gbxDining.Size = new System.Drawing.Size(113, 193);
            this.gbxDining.TabIndex = 2;
            this.gbxDining.TabStop = false;
            this.gbxDining.Text = "Dining";
            // 
            // radTakeOut
            // 
            this.radTakeOut.AutoSize = true;
            this.radTakeOut.Location = new System.Drawing.Point(18, 98);
            this.radTakeOut.Name = "radTakeOut";
            this.radTakeOut.Size = new System.Drawing.Size(76, 21);
            this.radTakeOut.TabIndex = 2;
            this.radTakeOut.Text = "Takeout";
            this.radTakeOut.UseVisualStyleBackColor = true;
            // 
            // radDelivery
            // 
            this.radDelivery.AutoSize = true;
            this.radDelivery.ForeColor = System.Drawing.SystemColors.Control;
            this.radDelivery.Location = new System.Drawing.Point(17, 71);
            this.radDelivery.Name = "radDelivery";
            this.radDelivery.Size = new System.Drawing.Size(77, 21);
            this.radDelivery.TabIndex = 1;
            this.radDelivery.Text = "Delivery";
            this.radDelivery.UseVisualStyleBackColor = true;
            this.radDelivery.CheckedChanged += new System.EventHandler(this.RadDelivery_CheckedChanged);
            // 
            // radDineIn
            // 
            this.radDineIn.AutoSize = true;
            this.radDineIn.Checked = true;
            this.radDineIn.Location = new System.Drawing.Point(18, 44);
            this.radDineIn.Name = "radDineIn";
            this.radDineIn.Size = new System.Drawing.Size(72, 21);
            this.radDineIn.TabIndex = 0;
            this.radDineIn.TabStop = true;
            this.radDineIn.Text = "Dine-In";
            this.radDineIn.UseVisualStyleBackColor = true;
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(42, 362);
            this.txtOrder.Multiline = true;
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.ReadOnly = true;
            this.txtOrder.Size = new System.Drawing.Size(517, 61);
            this.txtOrder.TabIndex = 3;
            this.txtOrder.Text = "(submitted order will be echoed here)";
            // 
            // mtbPhone
            // 
            this.mtbPhone.Location = new System.Drawing.Point(102, 459);
            this.mtbPhone.Mask = "(999) 000-0000";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(114, 25);
            this.mtbPhone.TabIndex = 4;
            // 
            // radThin
            // 
            this.radThin.AutoSize = true;
            this.radThin.Location = new System.Drawing.Point(7, 44);
            this.radThin.Name = "radThin";
            this.radThin.Size = new System.Drawing.Size(90, 21);
            this.radThin.TabIndex = 0;
            this.radThin.Text = "Thin Crust";
            this.radThin.UseVisualStyleBackColor = true;
            // 
            // radTraditional
            // 
            this.radTraditional.AutoSize = true;
            this.radTraditional.Checked = true;
            this.radTraditional.Location = new System.Drawing.Point(7, 71);
            this.radTraditional.Name = "radTraditional";
            this.radTraditional.Size = new System.Drawing.Size(94, 21);
            this.radTraditional.TabIndex = 1;
            this.radTraditional.TabStop = true;
            this.radTraditional.Text = "Traditional";
            this.radTraditional.UseVisualStyleBackColor = true;
            // 
            // radDeepDish
            // 
            this.radDeepDish.AutoSize = true;
            this.radDeepDish.Location = new System.Drawing.Point(7, 99);
            this.radDeepDish.Name = "radDeepDish";
            this.radDeepDish.Size = new System.Drawing.Size(90, 21);
            this.radDeepDish.TabIndex = 2;
            this.radDeepDish.Text = "Deep Dish";
            this.radDeepDish.UseVisualStyleBackColor = true;
            // 
            // radStuffedCrust
            // 
            this.radStuffedCrust.AutoSize = true;
            this.radStuffedCrust.Location = new System.Drawing.Point(7, 126);
            this.radStuffedCrust.Name = "radStuffedCrust";
            this.radStuffedCrust.Size = new System.Drawing.Size(107, 21);
            this.radStuffedCrust.TabIndex = 3;
            this.radStuffedCrust.Text = "Stuffed Crust";
            this.radStuffedCrust.UseVisualStyleBackColor = true;
            // 
            // gbxCrust
            // 
            this.gbxCrust.Controls.Add(this.lblStuffed);
            this.gbxCrust.Controls.Add(this.lblDeep);
            this.gbxCrust.Controls.Add(this.radStuffedCrust);
            this.gbxCrust.Controls.Add(this.radDeepDish);
            this.gbxCrust.Controls.Add(this.radTraditional);
            this.gbxCrust.Controls.Add(this.radThin);
            this.gbxCrust.ForeColor = System.Drawing.SystemColors.Control;
            this.gbxCrust.Location = new System.Drawing.Point(42, 143);
            this.gbxCrust.Name = "gbxCrust";
            this.gbxCrust.Size = new System.Drawing.Size(233, 193);
            this.gbxCrust.TabIndex = 0;
            this.gbxCrust.TabStop = false;
            this.gbxCrust.Text = "Crust Options";
            // 
            // lblStuffed
            // 
            this.lblStuffed.AutoSize = true;
            this.lblStuffed.Location = new System.Drawing.Point(108, 128);
            this.lblStuffed.Name = "lblStuffed";
            this.lblStuffed.Size = new System.Drawing.Size(66, 17);
            this.lblStuffed.TabIndex = 5;
            this.lblStuffed.Text = "- $2 extra";
            // 
            // lblDeep
            // 
            this.lblDeep.AutoSize = true;
            this.lblDeep.Location = new System.Drawing.Point(92, 101);
            this.lblDeep.Name = "lblDeep";
            this.lblDeep.Size = new System.Drawing.Size(66, 17);
            this.lblDeep.TabIndex = 4;
            this.lblDeep.Text = "- $2 extra";
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuCalculator,
            this.mnuHelp});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(899, 24);
            this.mnuMenu.TabIndex = 6;
            this.mnuMenu.Text = "Menu";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(93, 22);
            this.mnuFileExit.Text = "E&xit";
            this.mnuFileExit.Click += new System.EventHandler(this.MnuFileExit_Click);
            // 
            // mnuCalculator
            // 
            this.mnuCalculator.Name = "mnuCalculator";
            this.mnuCalculator.Size = new System.Drawing.Size(73, 20);
            this.mnuCalculator.Text = "&Calculator";
            this.mnuCalculator.Click += new System.EventHandler(this.MnuCalculator_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "&Help";
            this.mnuHelp.Click += new System.EventHandler(this.MnuHelp_Click);
            // 
            // gbxDrinks
            // 
            this.gbxDrinks.Controls.Add(this.chkSprite);
            this.gbxDrinks.Controls.Add(this.chkRootBeer);
            this.gbxDrinks.Controls.Add(this.chkCoke);
            this.gbxDrinks.Controls.Add(this.chkDietCoke);
            this.gbxDrinks.ForeColor = System.Drawing.SystemColors.Control;
            this.gbxDrinks.Location = new System.Drawing.Point(677, 143);
            this.gbxDrinks.Name = "gbxDrinks";
            this.gbxDrinks.Size = new System.Drawing.Size(156, 193);
            this.gbxDrinks.TabIndex = 3;
            this.gbxDrinks.TabStop = false;
            this.gbxDrinks.Text = "Beverages - 2 liter - $2.50 each";
            // 
            // chkSprite
            // 
            this.chkSprite.AutoSize = true;
            this.chkSprite.Location = new System.Drawing.Point(30, 101);
            this.chkSprite.Name = "chkSprite";
            this.chkSprite.Size = new System.Drawing.Size(63, 21);
            this.chkSprite.TabIndex = 12;
            this.chkSprite.Text = "Sprite";
            this.chkSprite.UseVisualStyleBackColor = true;
            // 
            // chkRootBeer
            // 
            this.chkRootBeer.AutoSize = true;
            this.chkRootBeer.Location = new System.Drawing.Point(30, 128);
            this.chkRootBeer.Name = "chkRootBeer";
            this.chkRootBeer.Size = new System.Drawing.Size(87, 21);
            this.chkRootBeer.TabIndex = 13;
            this.chkRootBeer.Text = "Root Beer";
            this.chkRootBeer.UseVisualStyleBackColor = true;
            // 
            // chkCoke
            // 
            this.chkCoke.AutoSize = true;
            this.chkCoke.Location = new System.Drawing.Point(30, 47);
            this.chkCoke.Name = "chkCoke";
            this.chkCoke.Size = new System.Drawing.Size(57, 21);
            this.chkCoke.TabIndex = 10;
            this.chkCoke.Text = "Coke";
            this.chkCoke.UseVisualStyleBackColor = true;
            // 
            // chkDietCoke
            // 
            this.chkDietCoke.AutoSize = true;
            this.chkDietCoke.Location = new System.Drawing.Point(30, 73);
            this.chkDietCoke.Name = "chkDietCoke";
            this.chkDietCoke.Size = new System.Drawing.Size(87, 21);
            this.chkDietCoke.TabIndex = 11;
            this.chkDietCoke.Text = "Diet Coke";
            this.chkDietCoke.UseVisualStyleBackColor = true;
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Location = new System.Drawing.Point(288, 101);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(161, 17);
            this.lblBasePrice.TabIndex = 5;
            this.lblBasePrice.Text = "Base Pizza Price = $10.75";
            // 
            // btnUpdatePrice
            // 
            this.btnUpdatePrice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUpdatePrice.Location = new System.Drawing.Point(458, 97);
            this.btnUpdatePrice.Name = "btnUpdatePrice";
            this.btnUpdatePrice.Size = new System.Drawing.Size(144, 24);
            this.btnUpdatePrice.TabIndex = 8;
            this.btnUpdatePrice.Text = "Update Base Price";
            this.btnUpdatePrice.UseVisualStyleBackColor = true;
            this.btnUpdatePrice.Click += new System.EventHandler(this.BtnUpdatePrice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Miriam Libre", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 71);
            this.label1.TabIndex = 9;
            this.label1.Text = "FREE DELIVERY!!!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(558, 344);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pbxOpenSign
            // 
            this.pbxOpenSign.Image = ((System.Drawing.Image)(resources.GetObject("pbxOpenSign.Image")));
            this.pbxOpenSign.Location = new System.Drawing.Point(71, 47);
            this.pbxOpenSign.Name = "pbxOpenSign";
            this.pbxOpenSign.Size = new System.Drawing.Size(85, 75);
            this.pbxOpenSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxOpenSign.TabIndex = 11;
            this.pbxOpenSign.TabStop = false;
            // 
            // tmrBlink
            // 
            this.tmrBlink.Enabled = true;
            this.tmrBlink.Interval = 1000;
            this.tmrBlink.Tick += new System.EventHandler(this.TmrBlink_Tick);
            // 
            // gbxTip
            // 
            this.gbxTip.Controls.Add(this.radBtnTipNo);
            this.gbxTip.Controls.Add(this.radBtnTip20);
            this.gbxTip.Controls.Add(this.radBtnTip15);
            this.gbxTip.Controls.Add(this.radBtnTip10);
            this.gbxTip.ForeColor = System.Drawing.SystemColors.Control;
            this.gbxTip.Location = new System.Drawing.Point(49, 513);
            this.gbxTip.Name = "gbxTip";
            this.gbxTip.Size = new System.Drawing.Size(208, 139);
            this.gbxTip.TabIndex = 3;
            this.gbxTip.TabStop = false;
            this.gbxTip.Text = "Add optional tip (not taxed):";
            // 
            // radBtnTipNo
            // 
            this.radBtnTipNo.AutoSize = true;
            this.radBtnTipNo.Checked = true;
            this.radBtnTipNo.Location = new System.Drawing.Point(26, 105);
            this.radBtnTipNo.Name = "radBtnTipNo";
            this.radBtnTipNo.Size = new System.Drawing.Size(89, 21);
            this.radBtnTipNo.TabIndex = 3;
            this.radBtnTipNo.TabStop = true;
            this.radBtnTipNo.Text = "No thanks";
            this.radBtnTipNo.UseVisualStyleBackColor = true;
            // 
            // radBtnTip20
            // 
            this.radBtnTip20.AutoSize = true;
            this.radBtnTip20.Location = new System.Drawing.Point(26, 78);
            this.radBtnTip20.Name = "radBtnTip20";
            this.radBtnTip20.Size = new System.Drawing.Size(51, 21);
            this.radBtnTip20.TabIndex = 2;
            this.radBtnTip20.Text = "20%";
            this.radBtnTip20.UseVisualStyleBackColor = true;
            // 
            // radBtnTip15
            // 
            this.radBtnTip15.AutoSize = true;
            this.radBtnTip15.ForeColor = System.Drawing.SystemColors.Control;
            this.radBtnTip15.Location = new System.Drawing.Point(25, 51);
            this.radBtnTip15.Name = "radBtnTip15";
            this.radBtnTip15.Size = new System.Drawing.Size(51, 21);
            this.radBtnTip15.TabIndex = 1;
            this.radBtnTip15.Text = "15%";
            this.radBtnTip15.UseVisualStyleBackColor = true;
            // 
            // radBtnTip10
            // 
            this.radBtnTip10.AutoSize = true;
            this.radBtnTip10.Location = new System.Drawing.Point(26, 24);
            this.radBtnTip10.Name = "radBtnTip10";
            this.radBtnTip10.Size = new System.Drawing.Size(51, 21);
            this.radBtnTip10.TabIndex = 0;
            this.radBtnTip10.Text = "10%";
            this.radBtnTip10.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Phone";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Location = new System.Drawing.Point(313, 537);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(150, 21);
            this.lblSubtotal.TabIndex = 13;
            this.lblSubtotal.Text = "Subtotal: $ __________";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTaxes
            // 
            this.lblTaxes.Location = new System.Drawing.Point(316, 566);
            this.lblTaxes.Name = "lblTaxes";
            this.lblTaxes.Size = new System.Drawing.Size(147, 17);
            this.lblTaxes.TabIndex = 14;
            this.lblTaxes.Text = "Tax Total: $ __________";
            this.lblTaxes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTip
            // 
            this.lblTip.Location = new System.Drawing.Point(316, 590);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(147, 22);
            this.lblTip.TabIndex = 15;
            this.lblTip.Text = "Tip: $ __________";
            this.lblTip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFinalPrice
            // 
            this.lblFinalPrice.Location = new System.Drawing.Point(316, 618);
            this.lblFinalPrice.Name = "lblFinalPrice";
            this.lblFinalPrice.Size = new System.Drawing.Size(147, 21);
            this.lblFinalPrice.TabIndex = 16;
            this.lblFinalPrice.Text = "Final Price: $ __________";
            this.lblFinalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft New Tai Lue", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnOrder.Location = new System.Drawing.Point(558, 539);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(307, 100);
            this.btnOrder.TabIndex = 17;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.BtnOrder_Click_1);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(899, 680);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblFinalPrice);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblTaxes);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbxTip);
            this.Controls.Add(this.pbxOpenSign);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdatePrice);
            this.Controls.Add(this.lblBasePrice);
            this.Controls.Add(this.gbxDrinks);
            this.Controls.Add(this.mtbPhone);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.gbxDining);
            this.Controls.Add(this.gbxToppings);
            this.Controls.Add(this.gbxCrust);
            this.Controls.Add(this.mnuMenu);
            this.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Luigi\'s Pizza";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaption;
            this.gbxToppings.ResumeLayout(false);
            this.gbxToppings.PerformLayout();
            this.gbxDining.ResumeLayout(false);
            this.gbxDining.PerformLayout();
            this.gbxCrust.ResumeLayout(false);
            this.gbxCrust.PerformLayout();
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.gbxDrinks.ResumeLayout(false);
            this.gbxDrinks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOpenSign)).EndInit();
            this.gbxTip.ResumeLayout(false);
            this.gbxTip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxToppings;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkOnions;
        private System.Windows.Forms.CheckBox chkPineapple;
        private System.Windows.Forms.CheckBox chkBlackOlives;
        private System.Windows.Forms.CheckBox chkCheese;
        private System.Windows.Forms.CheckBox chkProsciutto;
        private System.Windows.Forms.CheckBox chkBacon;
        private System.Windows.Forms.CheckBox chkSalami;
        private System.Windows.Forms.CheckBox chkSausage;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.GroupBox gbxDining;
        private System.Windows.Forms.RadioButton radTakeOut;
        private System.Windows.Forms.RadioButton radDelivery;
        private System.Windows.Forms.RadioButton radDineIn;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.RadioButton radThin;
        private System.Windows.Forms.RadioButton radTraditional;
        private System.Windows.Forms.RadioButton radDeepDish;
        private System.Windows.Forms.RadioButton radStuffedCrust;
        private System.Windows.Forms.GroupBox gbxCrust;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuCalculator;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.GroupBox gbxDrinks;
        private System.Windows.Forms.Label lblStuffed;
        private System.Windows.Forms.Label lblDeep;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.Button btnUpdatePrice;
        private System.Windows.Forms.CheckBox chkSprite;
        private System.Windows.Forms.CheckBox chkRootBeer;
        private System.Windows.Forms.CheckBox chkCoke;
        private System.Windows.Forms.CheckBox chkDietCoke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbxOpenSign;
        private System.Windows.Forms.Timer tmrBlink;
        private System.Windows.Forms.GroupBox gbxTip;
        private System.Windows.Forms.RadioButton radBtnTipNo;
        private System.Windows.Forms.RadioButton radBtnTip20;
        private System.Windows.Forms.RadioButton radBtnTip15;
        private System.Windows.Forms.RadioButton radBtnTip10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTaxes;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblFinalPrice;
        private System.Windows.Forms.Button btnOrder;
    }
}

