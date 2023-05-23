using Weather_App.Resources;

namespace Weather_App
{
    partial class FrmMain
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
            pnlContent = new Panel();
            pnlData = new Panel();
            lblLastUpdate = new Label();
            pnlError = new Panel();
            lblMessage = new Label();
            pnlLocation = new Panel();
            pbWorld = new PictureBox();
            lblWorld = new Label();
            pnlAstro = new Panel();
            pbAstro = new PictureBox();
            lblLine = new Label();
            lblPor = new Label();
            lblNascer = new Label();
            pnlWind = new Panel();
            lblDirecaoVento = new Label();
            pbDirecaoVento = new PictureBox();
            lblUnidadeVento = new Label();
            lblVento = new Label();
            pbVento = new PictureBox();
            pnlItens = new Panel();
            lblUnidadeUv = new Label();
            lblUndidadeUv = new Label();
            lblUnidadeRajada = new Label();
            pbRajada = new PictureBox();
            lblRajada = new Label();
            pbUv = new PictureBox();
            lblUv = new Label();
            pbHumidade = new PictureBox();
            lblHumidade = new Label();
            pbPressao = new PictureBox();
            lblUnidadePressao = new Label();
            lblPressao = new Label();
            pnlTemp = new Panel();
            pbIcon = new PictureBox();
            lblClima = new Label();
            lblTemp = new Label();
            pnlBuscar = new Panel();
            pnlSearch = new Panel();
            tbBuscar = new TextBox();
            lblBuscar = new LabelButton();
            pnlLineBuscar = new Panel();
            pnlContent.SuspendLayout();
            pnlData.SuspendLayout();
            pnlError.SuspendLayout();
            pnlLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbWorld).BeginInit();
            pnlAstro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAstro).BeginInit();
            pnlWind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDirecaoVento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbVento).BeginInit();
            pnlItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbRajada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHumidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPressao).BeginInit();
            pnlTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcon).BeginInit();
            pnlBuscar.SuspendLayout();
            pnlSearch.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(pnlData);
            pnlContent.Controls.Add(pnlBuscar);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(938, 667);
            pnlContent.TabIndex = 0;
            // 
            // pnlData
            // 
            pnlData.BorderStyle = BorderStyle.FixedSingle;
            pnlData.Controls.Add(lblLastUpdate);
            pnlData.Controls.Add(pnlError);
            pnlData.Controls.Add(pnlLocation);
            pnlData.Controls.Add(pnlAstro);
            pnlData.Controls.Add(pnlWind);
            pnlData.Controls.Add(pnlItens);
            pnlData.Controls.Add(pnlTemp);
            pnlData.Dock = DockStyle.Fill;
            pnlData.Location = new Point(0, 111);
            pnlData.Name = "pnlData";
            pnlData.Size = new Size(938, 556);
            pnlData.TabIndex = 5;
            // 
            // lblLastUpdate
            // 
            lblLastUpdate.Anchor = AnchorStyles.None;
            lblLastUpdate.ForeColor = SystemColors.ControlLightLight;
            lblLastUpdate.Location = new Point(393, 518);
            lblLastUpdate.Name = "lblLastUpdate";
            lblLastUpdate.Size = new Size(495, 23);
            lblLastUpdate.TabIndex = 22;
            lblLastUpdate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlError
            // 
            pnlError.Anchor = AnchorStyles.None;
            pnlError.BackColor = Color.Transparent;
            pnlError.Controls.Add(lblMessage);
            pnlError.ForeColor = Color.Transparent;
            pnlError.Location = new Point(223, 106);
            pnlError.Name = "pnlError";
            pnlError.Size = new Size(489, 373);
            pnlError.TabIndex = 21;
            // 
            // lblMessage
            // 
            lblMessage.Dock = DockStyle.Fill;
            lblMessage.Font = new Font("Source Serif Pro", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            lblMessage.Location = new Point(0, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(489, 373);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "Informe uma Cidade";
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlLocation
            // 
            pnlLocation.Anchor = AnchorStyles.None;
            pnlLocation.BackColor = Color.Transparent;
            pnlLocation.BorderStyle = BorderStyle.FixedSingle;
            pnlLocation.Controls.Add(pbWorld);
            pnlLocation.Controls.Add(lblWorld);
            pnlLocation.Location = new Point(394, 241);
            pnlLocation.Name = "pnlLocation";
            pnlLocation.Size = new Size(494, 98);
            pnlLocation.TabIndex = 20;
            pnlLocation.Visible = false;
            // 
            // pbWorld
            // 
            pbWorld.BackColor = Color.Transparent;
            pbWorld.BackgroundImage = Properties.Resources.world;
            pbWorld.BackgroundImageLayout = ImageLayout.Stretch;
            pbWorld.Location = new Point(19, 29);
            pbWorld.Name = "pbWorld";
            pbWorld.Size = new Size(40, 40);
            pbWorld.SizeMode = PictureBoxSizeMode.StretchImage;
            pbWorld.TabIndex = 8;
            pbWorld.TabStop = false;
            // 
            // lblWorld
            // 
            lblWorld.Font = new Font("Source Serif Pro Black", 17F, FontStyle.Bold, GraphicsUnit.Point);
            lblWorld.ForeColor = SystemColors.ControlLightLight;
            lblWorld.Location = new Point(65, 29);
            lblWorld.Name = "lblWorld";
            lblWorld.Size = new Size(407, 40);
            lblWorld.TabIndex = 7;
            lblWorld.Text = "N/A";
            lblWorld.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlAstro
            // 
            pnlAstro.Anchor = AnchorStyles.None;
            pnlAstro.BorderStyle = BorderStyle.FixedSingle;
            pnlAstro.Controls.Add(pbAstro);
            pnlAstro.Controls.Add(lblLine);
            pnlAstro.Controls.Add(lblPor);
            pnlAstro.Controls.Add(lblNascer);
            pnlAstro.Location = new Point(393, 383);
            pnlAstro.Name = "pnlAstro";
            pnlAstro.Size = new Size(495, 121);
            pnlAstro.TabIndex = 19;
            pnlAstro.Visible = false;
            // 
            // pbAstro
            // 
            pbAstro.BackColor = Color.Transparent;
            pbAstro.Location = new Point(40, 13);
            pbAstro.Name = "pbAstro";
            pbAstro.Size = new Size(60, 60);
            pbAstro.TabIndex = 3;
            pbAstro.TabStop = false;
            // 
            // lblLine
            // 
            lblLine.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblLine.ForeColor = SystemColors.ControlLightLight;
            lblLine.Location = new Point(-1, 23);
            lblLine.Name = "lblLine";
            lblLine.Size = new Size(495, 31);
            lblLine.TabIndex = 2;
            lblLine.Text = ". . . . . . . . . . . . . .";
            lblLine.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPor
            // 
            lblPor.BackColor = Color.Transparent;
            lblPor.Font = new Font("Source Serif Pro", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPor.ForeColor = SystemColors.ControlLightLight;
            lblPor.Location = new Point(364, 76);
            lblPor.Name = "lblPor";
            lblPor.Size = new Size(100, 44);
            lblPor.TabIndex = 1;
            lblPor.Text = "N/A";
            lblPor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNascer
            // 
            lblNascer.BackColor = Color.Transparent;
            lblNascer.Font = new Font("Source Serif Pro", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNascer.ForeColor = SystemColors.ControlLightLight;
            lblNascer.Location = new Point(25, 76);
            lblNascer.Name = "lblNascer";
            lblNascer.Size = new Size(100, 43);
            lblNascer.TabIndex = 0;
            lblNascer.Text = "N/A";
            lblNascer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlWind
            // 
            pnlWind.Anchor = AnchorStyles.None;
            pnlWind.BorderStyle = BorderStyle.FixedSingle;
            pnlWind.Controls.Add(lblDirecaoVento);
            pnlWind.Controls.Add(pbDirecaoVento);
            pnlWind.Controls.Add(lblUnidadeVento);
            pnlWind.Controls.Add(lblVento);
            pnlWind.Controls.Add(pbVento);
            pnlWind.Location = new Point(46, 383);
            pnlWind.Name = "pnlWind";
            pnlWind.Size = new Size(298, 121);
            pnlWind.TabIndex = 18;
            pnlWind.Visible = false;
            // 
            // lblDirecaoVento
            // 
            lblDirecaoVento.Font = new Font("Source Serif Pro Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblDirecaoVento.ForeColor = SystemColors.ControlLightLight;
            lblDirecaoVento.Location = new Point(68, 67);
            lblDirecaoVento.Name = "lblDirecaoVento";
            lblDirecaoVento.Size = new Size(215, 40);
            lblDirecaoVento.TabIndex = 5;
            lblDirecaoVento.Text = "N/A";
            lblDirecaoVento.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pbDirecaoVento
            // 
            pbDirecaoVento.Image = Properties.Resources.windDirection;
            pbDirecaoVento.Location = new Point(22, 67);
            pbDirecaoVento.Name = "pbDirecaoVento";
            pbDirecaoVento.Size = new Size(40, 40);
            pbDirecaoVento.TabIndex = 4;
            pbDirecaoVento.TabStop = false;
            // 
            // lblUnidadeVento
            // 
            lblUnidadeVento.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblUnidadeVento.ForeColor = SystemColors.ControlLightLight;
            lblUnidadeVento.Location = new Point(176, 23);
            lblUnidadeVento.Name = "lblUnidadeVento";
            lblUnidadeVento.Size = new Size(30, 31);
            lblUnidadeVento.TabIndex = 3;
            lblUnidadeVento.Text = "kph";
            lblUnidadeVento.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblVento
            // 
            lblVento.Font = new Font("Source Serif Pro Black", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblVento.ForeColor = SystemColors.ControlLightLight;
            lblVento.Location = new Point(68, 13);
            lblVento.Name = "lblVento";
            lblVento.Size = new Size(111, 40);
            lblVento.TabIndex = 1;
            lblVento.Text = "N/A";
            lblVento.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pbVento
            // 
            pbVento.Image = Properties.Resources.wind;
            pbVento.Location = new Point(22, 13);
            pbVento.Name = "pbVento";
            pbVento.Size = new Size(40, 40);
            pbVento.TabIndex = 0;
            pbVento.TabStop = false;
            // 
            // pnlItens
            // 
            pnlItens.Anchor = AnchorStyles.None;
            pnlItens.BorderStyle = BorderStyle.FixedSingle;
            pnlItens.Controls.Add(lblUnidadeUv);
            pnlItens.Controls.Add(lblUndidadeUv);
            pnlItens.Controls.Add(lblUnidadeRajada);
            pnlItens.Controls.Add(pbRajada);
            pnlItens.Controls.Add(lblRajada);
            pnlItens.Controls.Add(pbUv);
            pnlItens.Controls.Add(lblUv);
            pnlItens.Controls.Add(pbHumidade);
            pnlItens.Controls.Add(lblHumidade);
            pnlItens.Controls.Add(pbPressao);
            pnlItens.Controls.Add(lblUnidadePressao);
            pnlItens.Controls.Add(lblPressao);
            pnlItens.Location = new Point(393, 41);
            pnlItens.Name = "pnlItens";
            pnlItens.Size = new Size(495, 161);
            pnlItens.TabIndex = 17;
            pnlItens.Visible = false;
            // 
            // lblUnidadeUv
            // 
            lblUnidadeUv.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblUnidadeUv.ForeColor = SystemColors.ControlLightLight;
            lblUnidadeUv.Location = new Point(432, 31);
            lblUnidadeUv.Name = "lblUnidadeUv";
            lblUnidadeUv.Size = new Size(26, 31);
            lblUnidadeUv.TabIndex = 13;
            lblUnidadeUv.Text = "iuv";
            lblUnidadeUv.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUndidadeUv
            // 
            lblUndidadeUv.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblUndidadeUv.ForeColor = SystemColors.ControlLightLight;
            lblUndidadeUv.Location = new Point(174, 106);
            lblUndidadeUv.Name = "lblUndidadeUv";
            lblUndidadeUv.Size = new Size(26, 31);
            lblUndidadeUv.TabIndex = 12;
            lblUndidadeUv.Text = "%";
            lblUndidadeUv.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUnidadeRajada
            // 
            lblUnidadeRajada.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblUnidadeRajada.ForeColor = SystemColors.ControlLightLight;
            lblUnidadeRajada.Location = new Point(432, 109);
            lblUnidadeRajada.Name = "lblUnidadeRajada";
            lblUnidadeRajada.Size = new Size(30, 31);
            lblUnidadeRajada.TabIndex = 11;
            lblUnidadeRajada.Text = "kph";
            lblUnidadeRajada.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pbRajada
            // 
            pbRajada.BackColor = Color.Transparent;
            pbRajada.BackgroundImage = Properties.Resources.gust;
            pbRajada.BackgroundImageLayout = ImageLayout.Stretch;
            pbRajada.Location = new Point(278, 99);
            pbRajada.Name = "pbRajada";
            pbRajada.Size = new Size(40, 40);
            pbRajada.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRajada.TabIndex = 10;
            pbRajada.TabStop = false;
            // 
            // lblRajada
            // 
            lblRajada.Font = new Font("Source Serif Pro Black", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblRajada.ForeColor = SystemColors.ControlLightLight;
            lblRajada.Location = new Point(324, 99);
            lblRajada.Name = "lblRajada";
            lblRajada.Size = new Size(111, 40);
            lblRajada.TabIndex = 9;
            lblRajada.Text = "N/A";
            lblRajada.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pbUv
            // 
            pbUv.BackColor = Color.Transparent;
            pbUv.BackgroundImage = Properties.Resources.uv1;
            pbUv.BackgroundImageLayout = ImageLayout.Stretch;
            pbUv.Location = new Point(278, 21);
            pbUv.Name = "pbUv";
            pbUv.Size = new Size(40, 40);
            pbUv.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUv.TabIndex = 8;
            pbUv.TabStop = false;
            // 
            // lblUv
            // 
            lblUv.Font = new Font("Source Serif Pro Black", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblUv.ForeColor = SystemColors.ControlLightLight;
            lblUv.Location = new Point(324, 21);
            lblUv.Name = "lblUv";
            lblUv.Size = new Size(111, 40);
            lblUv.TabIndex = 7;
            lblUv.Text = "N/A";
            lblUv.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pbHumidade
            // 
            pbHumidade.BackColor = Color.Transparent;
            pbHumidade.BackgroundImage = Properties.Resources.humidity;
            pbHumidade.BackgroundImageLayout = ImageLayout.Stretch;
            pbHumidade.Location = new Point(20, 96);
            pbHumidade.Name = "pbHumidade";
            pbHumidade.Size = new Size(40, 40);
            pbHumidade.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHumidade.TabIndex = 6;
            pbHumidade.TabStop = false;
            // 
            // lblHumidade
            // 
            lblHumidade.Font = new Font("Source Serif Pro Black", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblHumidade.ForeColor = SystemColors.ControlLightLight;
            lblHumidade.Location = new Point(66, 96);
            lblHumidade.Name = "lblHumidade";
            lblHumidade.Size = new Size(111, 40);
            lblHumidade.TabIndex = 4;
            lblHumidade.Text = "N/A";
            lblHumidade.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pbPressao
            // 
            pbPressao.BackColor = Color.Transparent;
            pbPressao.BackgroundImage = Properties.Resources.preassure1;
            pbPressao.BackgroundImageLayout = ImageLayout.Stretch;
            pbPressao.Location = new Point(20, 21);
            pbPressao.Name = "pbPressao";
            pbPressao.Size = new Size(40, 40);
            pbPressao.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPressao.TabIndex = 3;
            pbPressao.TabStop = false;
            // 
            // lblUnidadePressao
            // 
            lblUnidadePressao.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblUnidadePressao.ForeColor = SystemColors.ControlLightLight;
            lblUnidadePressao.Location = new Point(174, 31);
            lblUnidadePressao.Name = "lblUnidadePressao";
            lblUnidadePressao.Size = new Size(26, 31);
            lblUnidadePressao.TabIndex = 2;
            lblUnidadePressao.Text = "mb";
            lblUnidadePressao.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPressao
            // 
            lblPressao.Font = new Font("Source Serif Pro Black", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblPressao.ForeColor = SystemColors.ControlLightLight;
            lblPressao.Location = new Point(66, 21);
            lblPressao.Name = "lblPressao";
            lblPressao.Size = new Size(111, 40);
            lblPressao.TabIndex = 1;
            lblPressao.Text = "N/A";
            lblPressao.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlTemp
            // 
            pnlTemp.Anchor = AnchorStyles.None;
            pnlTemp.BackColor = Color.Transparent;
            pnlTemp.BorderStyle = BorderStyle.FixedSingle;
            pnlTemp.Controls.Add(pbIcon);
            pnlTemp.Controls.Add(lblClima);
            pnlTemp.Controls.Add(lblTemp);
            pnlTemp.Location = new Point(46, 41);
            pnlTemp.Name = "pnlTemp";
            pnlTemp.Size = new Size(298, 298);
            pnlTemp.TabIndex = 16;
            pnlTemp.Visible = false;
            // 
            // pbIcon
            // 
            pbIcon.BackgroundImageLayout = ImageLayout.Center;
            pbIcon.Location = new Point(61, 21);
            pbIcon.Name = "pbIcon";
            pbIcon.Size = new Size(175, 175);
            pbIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pbIcon.TabIndex = 17;
            pbIcon.TabStop = false;
            // 
            // lblClima
            // 
            lblClima.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblClima.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblClima.ForeColor = Color.White;
            lblClima.Location = new Point(13, 233);
            lblClima.Name = "lblClima";
            lblClima.RightToLeft = RightToLeft.Yes;
            lblClima.Size = new Size(270, 24);
            lblClima.TabIndex = 4;
            lblClima.Text = "N/A";
            lblClima.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTemp
            // 
            lblTemp.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblTemp.ForeColor = Color.White;
            lblTemp.Location = new Point(13, 199);
            lblTemp.Name = "lblTemp";
            lblTemp.Size = new Size(270, 37);
            lblTemp.TabIndex = 8;
            lblTemp.Text = "N/A";
            lblTemp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlBuscar
            // 
            pnlBuscar.BorderStyle = BorderStyle.FixedSingle;
            pnlBuscar.Controls.Add(pnlSearch);
            pnlBuscar.Dock = DockStyle.Top;
            pnlBuscar.Location = new Point(0, 0);
            pnlBuscar.Name = "pnlBuscar";
            pnlBuscar.Size = new Size(938, 111);
            pnlBuscar.TabIndex = 4;
            // 
            // pnlSearch
            // 
            pnlSearch.Anchor = AnchorStyles.None;
            pnlSearch.Controls.Add(tbBuscar);
            pnlSearch.Controls.Add(lblBuscar);
            pnlSearch.Controls.Add(pnlLineBuscar);
            pnlSearch.Location = new Point(291, 35);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(360, 75);
            pnlSearch.TabIndex = 4;
            // 
            // tbBuscar
            // 
            tbBuscar.BackColor = Color.Black;
            tbBuscar.BorderStyle = BorderStyle.None;
            tbBuscar.ForeColor = Color.White;
            tbBuscar.Location = new Point(27, 25);
            tbBuscar.MaxLength = 50;
            tbBuscar.Name = "tbBuscar";
            tbBuscar.PlaceholderText = "Cidade";
            tbBuscar.Size = new Size(200, 16);
            tbBuscar.TabIndex = 1;
            tbBuscar.Enter += tbBuscar_Enter;
            tbBuscar.Leave += tbBuscar_Leave;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.ForeColor = Color.White;
            lblBuscar.Location = new Point(257, 23);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Padding = new Padding(15, 5, 15, 5);
            lblBuscar.Size = new Size(72, 25);
            lblBuscar.TabIndex = 2;
            lblBuscar.TabStop = true;
            lblBuscar.Text = "Buscar";
            lblBuscar.KeyDown += lblBuscar_KeyDown;
            lblBuscar.Enter += lblBuscar_Enter;
            lblBuscar.Leave += lblBuscar_Leave;
            lblBuscar.MouseClick += lblBuscar_MouseClick;
            lblBuscar.MouseEnter += lblBuscar_MouseEnter;
            lblBuscar.MouseLeave += lblBuscar_MouseLeave;
            // 
            // pnlLineBuscar
            // 
            pnlLineBuscar.BackColor = Color.Gray;
            pnlLineBuscar.Location = new Point(27, 47);
            pnlLineBuscar.Name = "pnlLineBuscar";
            pnlLineBuscar.Size = new Size(200, 1);
            pnlLineBuscar.TabIndex = 3;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(938, 667);
            Controls.Add(pnlContent);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Shown += FrmMain_Shown;
            pnlContent.ResumeLayout(false);
            pnlData.ResumeLayout(false);
            pnlError.ResumeLayout(false);
            pnlLocation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbWorld).EndInit();
            pnlAstro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbAstro).EndInit();
            pnlWind.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbDirecaoVento).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbVento).EndInit();
            pnlItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbRajada).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHumidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPressao).EndInit();
            pnlTemp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbIcon).EndInit();
            pnlBuscar.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContent;
        private TextBox tbBuscar;
        private Panel pnlLineBuscar;
        private LabelButton lblBuscar;
        private Panel pnlData;
        private Panel pnlTemp;
        private Label lblTemp;
        private Label lblClima;
        private Panel pnlBuscar;
        private Panel pnlSearch;
        private PictureBox pbIcon;
        private Panel pnlItens;
        private Panel pnlWind;
        private Label lblDirecaoVento;
        private PictureBox pbDirecaoVento;
        private Label lblUnidadeVento;
        private Label lblVento;
        private PictureBox pbVento;
        private PictureBox pbPressao;
        private Label lblUnidadePressao;
        private Label lblPressao;
        private PictureBox pbHumidade;
        private Label lblHumidade;
        private PictureBox pbUv;
        private Label lblUv;
        private Label lblUnidadeRajada;
        private PictureBox pbRajada;
        private Label lblRajada;
        private Panel pnlAstro;
        private Label lblLine;
        private Label lblPor;
        private Label lblNascer;
        private PictureBox pbAstro;
        private Panel pnlLocation;
        private PictureBox pbWorld;
        private Label lblWorld;
        private Label lblUnidadeUv;
        private Label lblUndidadeUv;
        private Panel pnlError;
        private Label lblMessage;
        private Label lblLastUpdate;
    }
}