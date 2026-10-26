namespace Proyecto_I_CidGuzman
{
    partial class Juego
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            juegoPanel = new Panel();
            jugadorLabel = new Label();
            resultadoLabel = new Label();
            label8 = new Label();
            vidasLabel = new Label();
            label6 = new Label();
            dificultadLabel = new Label();
            aceptarButton = new Button();
            resultadoTextBox = new TextBox();
            label2 = new Label();
            igualLabel = new Label();
            n2Label = new Label();
            opLabel = new Label();
            n1Label = new Label();
            menuPanel = new Panel();
            aceptarNombreButton = new Button();
            nJugador2TextBox = new TextBox();
            nJugador1TextBox = new TextBox();
            dosJugadoresRB = new RadioButton();
            unJugadorRB = new RadioButton();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            label1 = new Label();
            infoPanel = new Panel();
            erroresLabel = new Label();
            aciertosLabel = new Label();
            puntosLabel = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            menuButton = new Button();
            resultadosPanel = new Panel();
            resultadosDGV = new DataGridView();
            nombreCol = new DataGridViewTextBoxColumn();
            puntosCol = new DataGridViewTextBoxColumn();
            label12 = new Label();
            juegoPanel.SuspendLayout();
            menuPanel.SuspendLayout();
            infoPanel.SuspendLayout();
            resultadosPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resultadosDGV).BeginInit();
            SuspendLayout();
            // 
            // juegoPanel
            // 
            juegoPanel.BackColor = Color.FromArgb(30, 30, 30);
            juegoPanel.Controls.Add(jugadorLabel);
            juegoPanel.Controls.Add(resultadoLabel);
            juegoPanel.Controls.Add(label8);
            juegoPanel.Controls.Add(vidasLabel);
            juegoPanel.Controls.Add(label6);
            juegoPanel.Controls.Add(dificultadLabel);
            juegoPanel.Controls.Add(aceptarButton);
            juegoPanel.Controls.Add(resultadoTextBox);
            juegoPanel.Controls.Add(label2);
            juegoPanel.Controls.Add(igualLabel);
            juegoPanel.Controls.Add(n2Label);
            juegoPanel.Controls.Add(opLabel);
            juegoPanel.Controls.Add(n1Label);
            juegoPanel.Location = new Point(12, 54);
            juegoPanel.Name = "juegoPanel";
            juegoPanel.Size = new Size(653, 357);
            juegoPanel.TabIndex = 0;
            // 
            // jugadorLabel
            // 
            jugadorLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            jugadorLabel.BackColor = Color.Transparent;
            jugadorLabel.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jugadorLabel.ForeColor = Color.FromArgb(3, 218, 197);
            jugadorLabel.Location = new Point(176, 17);
            jugadorLabel.Name = "jugadorLabel";
            jugadorLabel.Size = new Size(301, 24);
            jugadorLabel.TabIndex = 14;
            jugadorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // resultadoLabel
            // 
            resultadoLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            resultadoLabel.BackColor = Color.Transparent;
            resultadoLabel.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultadoLabel.ForeColor = Color.FromArgb(187, 134, 252);
            resultadoLabel.Location = new Point(29, 227);
            resultadoLabel.Name = "resultadoLabel";
            resultadoLabel.Size = new Size(601, 74);
            resultadoLabel.TabIndex = 17;
            resultadoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(187, 134, 252);
            label8.Location = new Point(10, 323);
            label8.Name = "label8";
            label8.Size = new Size(250, 24);
            label8.TabIndex = 16;
            label8.Text = "NIVEL DE DIFICULTAD:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // vidasLabel
            // 
            vidasLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            vidasLabel.BackColor = Color.Transparent;
            vidasLabel.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vidasLabel.ForeColor = Color.FromArgb(3, 218, 197);
            vidasLabel.Location = new Point(598, 323);
            vidasLabel.Name = "vidasLabel";
            vidasLabel.Size = new Size(45, 24);
            vidasLabel.TabIndex = 15;
            vidasLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(187, 134, 252);
            label6.Location = new Point(510, 323);
            label6.Name = "label6";
            label6.Size = new Size(82, 24);
            label6.TabIndex = 14;
            label6.Text = "VIDAS:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dificultadLabel
            // 
            dificultadLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dificultadLabel.BackColor = Color.Transparent;
            dificultadLabel.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dificultadLabel.ForeColor = Color.FromArgb(3, 218, 197);
            dificultadLabel.Location = new Point(266, 323);
            dificultadLabel.Name = "dificultadLabel";
            dificultadLabel.Size = new Size(42, 24);
            dificultadLabel.TabIndex = 14;
            dificultadLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // aceptarButton
            // 
            aceptarButton.BackColor = Color.FromArgb(187, 134, 252);
            aceptarButton.FlatStyle = FlatStyle.Popup;
            aceptarButton.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aceptarButton.ForeColor = SystemColors.ActiveCaptionText;
            aceptarButton.Location = new Point(283, 184);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(93, 36);
            aceptarButton.TabIndex = 6;
            aceptarButton.Text = "ACEPTAR";
            aceptarButton.UseVisualStyleBackColor = false;
            aceptarButton.Click += aceptarButton_Click;
            // 
            // resultadoTextBox
            // 
            resultadoTextBox.BackColor = Color.FromArgb(30, 30, 30);
            resultadoTextBox.BorderStyle = BorderStyle.None;
            resultadoTextBox.Font = new Font("Consolas", 20.25F);
            resultadoTextBox.ForeColor = Color.FromArgb(3, 218, 197);
            resultadoTextBox.Location = new Point(478, 111);
            resultadoTextBox.Name = "resultadoTextBox";
            resultadoTextBox.PlaceholderText = "?";
            resultadoTextBox.Size = new Size(50, 32);
            resultadoTextBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(187, 134, 252);
            label2.ImageAlign = ContentAlignment.TopLeft;
            label2.Location = new Point(5, 41);
            label2.Name = "label2";
            label2.Size = new Size(645, 50);
            label2.TabIndex = 4;
            label2.Text = "Digite el resultado de la siguiente operacion:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // igualLabel
            // 
            igualLabel.BackColor = Color.Transparent;
            igualLabel.Font = new Font("Consolas", 20.25F);
            igualLabel.ForeColor = Color.FromArgb(3, 218, 197);
            igualLabel.Location = new Point(391, 102);
            igualLabel.Name = "igualLabel";
            igualLabel.Size = new Size(50, 50);
            igualLabel.TabIndex = 3;
            igualLabel.Text = "=";
            igualLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // n2Label
            // 
            n2Label.BackColor = Color.Transparent;
            n2Label.Font = new Font("Consolas", 20.25F);
            n2Label.ForeColor = Color.FromArgb(3, 218, 197);
            n2Label.Location = new Point(304, 102);
            n2Label.Name = "n2Label";
            n2Label.Size = new Size(50, 50);
            n2Label.TabIndex = 2;
            n2Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // opLabel
            // 
            opLabel.BackColor = Color.Transparent;
            opLabel.Font = new Font("Consolas", 20.25F);
            opLabel.ForeColor = Color.FromArgb(3, 218, 197);
            opLabel.Location = new Point(217, 102);
            opLabel.Name = "opLabel";
            opLabel.Size = new Size(50, 50);
            opLabel.TabIndex = 1;
            opLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // n1Label
            // 
            n1Label.BackColor = Color.Transparent;
            n1Label.Font = new Font("Consolas", 20.25F);
            n1Label.ForeColor = Color.FromArgb(3, 218, 197);
            n1Label.Location = new Point(130, 102);
            n1Label.Name = "n1Label";
            n1Label.Size = new Size(50, 50);
            n1Label.TabIndex = 0;
            n1Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuPanel
            // 
            menuPanel.BackColor = Color.FromArgb(30, 30, 30);
            menuPanel.Controls.Add(aceptarNombreButton);
            menuPanel.Controls.Add(nJugador2TextBox);
            menuPanel.Controls.Add(nJugador1TextBox);
            menuPanel.Controls.Add(dosJugadoresRB);
            menuPanel.Controls.Add(unJugadorRB);
            menuPanel.Controls.Add(label11);
            menuPanel.Controls.Add(label10);
            menuPanel.Controls.Add(label9);
            menuPanel.Controls.Add(label7);
            menuPanel.Location = new Point(12, 48);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(805, 363);
            menuPanel.TabIndex = 18;
            // 
            // aceptarNombreButton
            // 
            aceptarNombreButton.BackColor = Color.FromArgb(187, 134, 252);
            aceptarNombreButton.FlatStyle = FlatStyle.Popup;
            aceptarNombreButton.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aceptarNombreButton.ForeColor = SystemColors.ActiveCaptionText;
            aceptarNombreButton.Location = new Point(340, 295);
            aceptarNombreButton.Name = "aceptarNombreButton";
            aceptarNombreButton.Size = new Size(124, 36);
            aceptarNombreButton.TabIndex = 19;
            aceptarNombreButton.Text = "ACEPTAR";
            aceptarNombreButton.UseVisualStyleBackColor = false;
            aceptarNombreButton.Click += aceptarNombreButton_Click;
            // 
            // nJugador2TextBox
            // 
            nJugador2TextBox.BackColor = Color.FromArgb(30, 30, 30);
            nJugador2TextBox.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nJugador2TextBox.ForeColor = Color.FromArgb(3, 218, 197);
            nJugador2TextBox.Location = new Point(267, 243);
            nJugador2TextBox.MaxLength = 20;
            nJugador2TextBox.Name = "nJugador2TextBox";
            nJugador2TextBox.PlaceholderText = "NOMBRE JUGADOR 2";
            nJugador2TextBox.Size = new Size(270, 32);
            nJugador2TextBox.TabIndex = 26;
            nJugador2TextBox.Visible = false;
            // 
            // nJugador1TextBox
            // 
            nJugador1TextBox.BackColor = Color.FromArgb(30, 30, 30);
            nJugador1TextBox.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nJugador1TextBox.ForeColor = Color.FromArgb(3, 218, 197);
            nJugador1TextBox.Location = new Point(267, 191);
            nJugador1TextBox.MaxLength = 20;
            nJugador1TextBox.Name = "nJugador1TextBox";
            nJugador1TextBox.PlaceholderText = "NOMBRE JUGADOR 1";
            nJugador1TextBox.Size = new Size(270, 32);
            nJugador1TextBox.TabIndex = 25;
            // 
            // dosJugadoresRB
            // 
            dosJugadoresRB.BackColor = Color.FromArgb(3, 218, 197);
            dosJugadoresRB.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dosJugadoresRB.ForeColor = Color.Black;
            dosJugadoresRB.Location = new Point(414, 139);
            dosJugadoresRB.Name = "dosJugadoresRB";
            dosJugadoresRB.Size = new Size(173, 32);
            dosJugadoresRB.TabIndex = 24;
            dosJugadoresRB.Text = "2 JUGADORES";
            dosJugadoresRB.TextAlign = ContentAlignment.MiddleCenter;
            dosJugadoresRB.UseVisualStyleBackColor = false;
            dosJugadoresRB.CheckedChanged += dosJugadoresRB_CheckedChanged;
            // 
            // unJugadorRB
            // 
            unJugadorRB.BackColor = Color.FromArgb(3, 218, 197);
            unJugadorRB.Checked = true;
            unJugadorRB.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unJugadorRB.ForeColor = Color.Black;
            unJugadorRB.Location = new Point(218, 139);
            unJugadorRB.Name = "unJugadorRB";
            unJugadorRB.Size = new Size(173, 32);
            unJugadorRB.TabIndex = 23;
            unJugadorRB.TabStop = true;
            unJugadorRB.Text = "1 JUGADOR";
            unJugadorRB.TextAlign = ContentAlignment.MiddleCenter;
            unJugadorRB.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(30, 30, 30);
            label11.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(187, 134, 252);
            label11.Location = new Point(659, 336);
            label11.Name = "label11";
            label11.Size = new Size(140, 15);
            label11.TabIndex = 22;
            label11.Text = "CID GUZMAN CHAVERRI";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(30, 30, 30);
            label10.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(187, 134, 252);
            label10.Location = new Point(10, 338);
            label10.Name = "label10";
            label10.Size = new Size(189, 15);
            label10.TabIndex = 21;
            label10.Text = "PROYECTO I PROGRAMACION II";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(30, 30, 30);
            label9.Font = new Font("Consolas", 20.25F);
            label9.ForeColor = Color.FromArgb(187, 134, 252);
            label9.Location = new Point(125, 91);
            label9.Name = "label9";
            label9.Size = new Size(554, 32);
            label9.TabIndex = 20;
            label9.Text = "SELECCIONE LA CANTIDAD DE JUGADORES:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(30, 30, 30);
            label7.Font = new Font("Consolas", 20.25F);
            label7.ForeColor = Color.FromArgb(187, 134, 252);
            label7.Location = new Point(245, 17);
            label7.Name = "label7";
            label7.Size = new Size(314, 32);
            label7.TabIndex = 19;
            label7.Text = "BIENVENIDO AL JUEGO!";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(30, 30, 30);
            label1.Font = new Font("Consolas", 20.25F);
            label1.ForeColor = Color.FromArgb(187, 134, 252);
            label1.Location = new Point(262, 9);
            label1.Name = "label1";
            label1.Size = new Size(299, 32);
            label1.TabIndex = 1;
            label1.Text = "JUEGO DE ARITMETICA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // infoPanel
            // 
            infoPanel.BackColor = Color.FromArgb(30, 30, 30);
            infoPanel.Controls.Add(erroresLabel);
            infoPanel.Controls.Add(aciertosLabel);
            infoPanel.Controls.Add(puntosLabel);
            infoPanel.Controls.Add(label5);
            infoPanel.Controls.Add(label4);
            infoPanel.Controls.Add(label3);
            infoPanel.Location = new Point(671, 54);
            infoPanel.Name = "infoPanel";
            infoPanel.Size = new Size(146, 357);
            infoPanel.TabIndex = 7;
            // 
            // erroresLabel
            // 
            erroresLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            erroresLabel.BackColor = Color.Transparent;
            erroresLabel.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            erroresLabel.ForeColor = Color.FromArgb(3, 218, 197);
            erroresLabel.Location = new Point(20, 291);
            erroresLabel.Name = "erroresLabel";
            erroresLabel.Size = new Size(106, 24);
            erroresLabel.TabIndex = 13;
            erroresLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // aciertosLabel
            // 
            aciertosLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            aciertosLabel.BackColor = Color.Transparent;
            aciertosLabel.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aciertosLabel.ForeColor = Color.FromArgb(3, 218, 197);
            aciertosLabel.Location = new Point(20, 191);
            aciertosLabel.Name = "aciertosLabel";
            aciertosLabel.Size = new Size(106, 24);
            aciertosLabel.TabIndex = 12;
            aciertosLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // puntosLabel
            // 
            puntosLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            puntosLabel.BackColor = Color.Transparent;
            puntosLabel.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            puntosLabel.ForeColor = Color.FromArgb(3, 218, 197);
            puntosLabel.Location = new Point(20, 91);
            puntosLabel.Name = "puntosLabel";
            puntosLabel.Size = new Size(106, 24);
            puntosLabel.TabIndex = 11;
            puntosLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(187, 134, 252);
            label5.Location = new Point(20, 141);
            label5.Name = "label5";
            label5.Size = new Size(106, 24);
            label5.TabIndex = 10;
            label5.Text = "ACIERTOS";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(187, 134, 252);
            label4.Location = new Point(20, 241);
            label4.Name = "label4";
            label4.Size = new Size(106, 24);
            label4.TabIndex = 9;
            label4.Text = "ERRORES";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(187, 134, 252);
            label3.Location = new Point(20, 41);
            label3.Name = "label3";
            label3.Size = new Size(106, 24);
            label3.TabIndex = 8;
            label3.Text = "PUNTOS";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuButton
            // 
            menuButton.BackColor = Color.FromArgb(187, 134, 252);
            menuButton.FlatStyle = FlatStyle.Popup;
            menuButton.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuButton.ForeColor = SystemColors.ActiveCaptionText;
            menuButton.Location = new Point(349, 422);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(124, 36);
            menuButton.TabIndex = 18;
            menuButton.Text = "MENU";
            menuButton.UseVisualStyleBackColor = false;
            menuButton.Click += menuButton_Click;
            // 
            // resultadosPanel
            // 
            resultadosPanel.BackColor = Color.FromArgb(30, 30, 30);
            resultadosPanel.Controls.Add(resultadosDGV);
            resultadosPanel.Controls.Add(label12);
            resultadosPanel.Location = new Point(12, 48);
            resultadosPanel.Name = "resultadosPanel";
            resultadosPanel.Size = new Size(805, 363);
            resultadosPanel.TabIndex = 19;
            // 
            // resultadosDGV
            // 
            resultadosDGV.AllowUserToAddRows = false;
            resultadosDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(187, 134, 252);
            dataGridViewCellStyle1.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.NullValue = null;
            resultadosDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resultadosDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            resultadosDGV.BackgroundColor = Color.FromArgb(187, 134, 252);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(187, 134, 252);
            dataGridViewCellStyle2.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            resultadosDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            resultadosDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultadosDGV.Columns.AddRange(new DataGridViewColumn[] { nombreCol, puntosCol });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(187, 134, 252);
            dataGridViewCellStyle3.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            resultadosDGV.DefaultCellStyle = dataGridViewCellStyle3;
            resultadosDGV.EnableHeadersVisualStyles = false;
            resultadosDGV.Location = new Point(32, 52);
            resultadosDGV.Name = "resultadosDGV";
            resultadosDGV.ReadOnly = true;
            resultadosDGV.Size = new Size(741, 281);
            resultadosDGV.TabIndex = 21;
            // 
            // nombreCol
            // 
            nombreCol.HeaderText = "JUGADOR";
            nombreCol.Name = "nombreCol";
            nombreCol.ReadOnly = true;
            // 
            // puntosCol
            // 
            puntosCol.HeaderText = "PUNTOS";
            puntosCol.Name = "puntosCol";
            puntosCol.ReadOnly = true;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(30, 30, 30);
            label12.Font = new Font("Consolas", 20.25F);
            label12.ForeColor = Color.FromArgb(187, 134, 252);
            label12.Location = new Point(223, 15);
            label12.Name = "label12";
            label12.Size = new Size(359, 32);
            label12.TabIndex = 20;
            label12.Text = "RESULTADOS DE PARTIDAS:";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Juego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            BackgroundImage = Properties.Resources.math_thin_line_dark_pattern_mathematics_education_seamless_background_vector;
            ClientSize = new Size(823, 473);
            Controls.Add(resultadosPanel);
            Controls.Add(menuPanel);
            Controls.Add(menuButton);
            Controls.Add(label1);
            Controls.Add(juegoPanel);
            Controls.Add(infoPanel);
            Name = "Juego";
            Text = "Juego de Aritmetica";
            Load += Form1_Load;
            juegoPanel.ResumeLayout(false);
            juegoPanel.PerformLayout();
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            infoPanel.ResumeLayout(false);
            resultadosPanel.ResumeLayout(false);
            resultadosPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)resultadosDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel juegoPanel;
        private Label label1;
        private Label n1Label;
        private Label igualLabel;
        private Label n2Label;
        private Label opLabel;
        private Label label2;
        private TextBox resultadoTextBox;
        private Button aceptarButton;
        private Panel infoPanel;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label8;
        private Label vidasLabel;
        private Label label6;
        private Label dificultadLabel;
        private Label erroresLabel;
        private Label aciertosLabel;
        private Label puntosLabel;
        private Label resultadoLabel;
        private Label jugadorLabel;
        private Button menuButton;
        private Panel menuPanel;
        private Label label10;
        private Label label9;
        private Label label7;
        private RadioButton unJugadorRB;
        private Label label11;
        private RadioButton dosJugadoresRB;
        private TextBox nJugador1TextBox;
        private Button aceptarNombreButton;
        private TextBox nJugador2TextBox;
        private Panel resultadosPanel;
        private DataGridView resultadosDGV;
        private DataGridViewTextBoxColumn nombreCol;
        private DataGridViewTextBoxColumn puntosCol;
        private Label label12;
    }
}
