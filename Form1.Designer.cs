namespace agendaWF
{
    partial class Formulario
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label sobrenomeLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label nascimentoLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label telefone_1Label;
            System.Windows.Forms.Label telefone_2Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario));
            this.listaContatoDBDataSet = new agendaWF.listaContatoDBDataSet();
            this.cadastroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroTableAdapter = new agendaWF.listaContatoDBDataSetTableAdapters.CadastroTableAdapter();
            this.tableAdapterManager = new agendaWF.listaContatoDBDataSetTableAdapters.TableAdapterManager();
            this.cadastroBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cadastroBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.sobrenomeTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.nascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.sexoTextBox = new System.Windows.Forms.TextBox();
            this.telefone_1TextBox = new System.Windows.Forms.TextBox();
            this.telefone_2TextBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            idLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            sobrenomeLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            nascimentoLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            telefone_1Label = new System.Windows.Forms.Label();
            telefone_2Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaContatoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroBindingNavigator)).BeginInit();
            this.cadastroBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(13, 152);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(13, 178);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // sobrenomeLabel
            // 
            sobrenomeLabel.AutoSize = true;
            sobrenomeLabel.Location = new System.Drawing.Point(13, 204);
            sobrenomeLabel.Name = "sobrenomeLabel";
            sobrenomeLabel.Size = new System.Drawing.Size(64, 13);
            sobrenomeLabel.TabIndex = 5;
            sobrenomeLabel.Text = "Sobrenome:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(13, 230);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(43, 13);
            cidadeLabel.TabIndex = 7;
            cidadeLabel.Text = "Cidade:";
            // 
            // nascimentoLabel
            // 
            nascimentoLabel.AutoSize = true;
            nascimentoLabel.Location = new System.Drawing.Point(13, 257);
            nascimentoLabel.Name = "nascimentoLabel";
            nascimentoLabel.Size = new System.Drawing.Size(66, 13);
            nascimentoLabel.TabIndex = 9;
            nascimentoLabel.Text = "Nascimento:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(231, 334);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 11;
            estadoLabel.Text = "Estado:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Location = new System.Drawing.Point(13, 334);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(34, 13);
            sexoLabel.TabIndex = 13;
            sexoLabel.Text = "Sexo:";
            // 
            // telefone_1Label
            // 
            telefone_1Label.AutoSize = true;
            telefone_1Label.Location = new System.Drawing.Point(13, 282);
            telefone_1Label.Name = "telefone_1Label";
            telefone_1Label.Size = new System.Drawing.Size(61, 13);
            telefone_1Label.TabIndex = 15;
            telefone_1Label.Text = "Telefone 1:";
            // 
            // telefone_2Label
            // 
            telefone_2Label.AutoSize = true;
            telefone_2Label.Location = new System.Drawing.Point(13, 308);
            telefone_2Label.Name = "telefone_2Label";
            telefone_2Label.Size = new System.Drawing.Size(61, 13);
            telefone_2Label.TabIndex = 17;
            telefone_2Label.Text = "Telefone 2:";
            // 
            // listaContatoDBDataSet
            // 
            this.listaContatoDBDataSet.DataSetName = "listaContatoDBDataSet";
            this.listaContatoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadastroBindingSource
            // 
            this.cadastroBindingSource.DataMember = "Cadastro";
            this.cadastroBindingSource.DataSource = this.listaContatoDBDataSet;
            // 
            // cadastroTableAdapter
            // 
            this.cadastroTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CadastroTableAdapter = this.cadastroTableAdapter;
            this.tableAdapterManager.UpdateOrder = agendaWF.listaContatoDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cadastroBindingNavigator
            // 
            this.cadastroBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cadastroBindingNavigator.BindingSource = this.cadastroBindingSource;
            this.cadastroBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cadastroBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cadastroBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cadastroBindingNavigatorSaveItem});
            this.cadastroBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cadastroBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cadastroBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cadastroBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cadastroBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cadastroBindingNavigator.Name = "cadastroBindingNavigator";
            this.cadastroBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cadastroBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.cadastroBindingNavigator.TabIndex = 0;
            this.cadastroBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cadastroBindingNavigatorSaveItem
            // 
            this.cadastroBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cadastroBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroBindingNavigatorSaveItem.Image")));
            this.cadastroBindingNavigatorSaveItem.Name = "cadastroBindingNavigatorSaveItem";
            this.cadastroBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cadastroBindingNavigatorSaveItem.Text = "Save Data";
            this.cadastroBindingNavigatorSaveItem.Click += new System.EventHandler(this.cadastroBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(85, 149);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(279, 20);
            this.idTextBox.TabIndex = 2;
            this.idTextBox.Text = "Auto preenchido";
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(85, 175);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(279, 20);
            this.nomeTextBox.TabIndex = 4;
            // 
            // sobrenomeTextBox
            // 
            this.sobrenomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroBindingSource, "Sobrenome", true));
            this.sobrenomeTextBox.Location = new System.Drawing.Point(85, 201);
            this.sobrenomeTextBox.Name = "sobrenomeTextBox";
            this.sobrenomeTextBox.Size = new System.Drawing.Size(279, 20);
            this.sobrenomeTextBox.TabIndex = 6;
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroBindingSource, "Cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(85, 227);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(279, 20);
            this.cidadeTextBox.TabIndex = 8;
            // 
            // nascimentoDateTimePicker
            // 
            this.nascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cadastroBindingSource, "Nascimento", true));
            this.nascimentoDateTimePicker.Location = new System.Drawing.Point(85, 253);
            this.nascimentoDateTimePicker.Name = "nascimentoDateTimePicker";
            this.nascimentoDateTimePicker.Size = new System.Drawing.Size(279, 20);
            this.nascimentoDateTimePicker.TabIndex = 10;
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroBindingSource, "Estado", true));
            this.estadoTextBox.Location = new System.Drawing.Point(307, 331);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(57, 20);
            this.estadoTextBox.TabIndex = 18;
            this.estadoTextBox.TextChanged += new System.EventHandler(this.estadoTextBox_TextChanged);
            // 
            // sexoTextBox
            // 
            this.sexoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroBindingSource, "Sexo", true));
            this.sexoTextBox.Location = new System.Drawing.Point(85, 331);
            this.sexoTextBox.Name = "sexoTextBox";
            this.sexoTextBox.Size = new System.Drawing.Size(57, 20);
            this.sexoTextBox.TabIndex = 16;
            this.sexoTextBox.TextChanged += new System.EventHandler(this.sexoTextBox_TextChanged);
            // 
            // telefone_1TextBox
            // 
            this.telefone_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroBindingSource, "Telefone 1", true));
            this.telefone_1TextBox.Location = new System.Drawing.Point(85, 279);
            this.telefone_1TextBox.Name = "telefone_1TextBox";
            this.telefone_1TextBox.Size = new System.Drawing.Size(279, 20);
            this.telefone_1TextBox.TabIndex = 12;
            // 
            // telefone_2TextBox
            // 
            this.telefone_2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroBindingSource, "Telefone 2", true));
            this.telefone_2TextBox.Location = new System.Drawing.Point(85, 305);
            this.telefone_2TextBox.Name = "telefone_2TextBox";
            this.telefone_2TextBox.Size = new System.Drawing.Size(279, 20);
            this.telefone_2TextBox.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::agendaWF.Properties.Resources.logoCompany1;
            this.pictureBox2.Location = new System.Drawing.Point(85, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(204, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::agendaWF.Properties.Resources.logoCompany;
            this.pictureBox1.Location = new System.Drawing.Point(381, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(407, 339);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 367);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(sobrenomeLabel);
            this.Controls.Add(this.sobrenomeTextBox);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.cidadeTextBox);
            this.Controls.Add(nascimentoLabel);
            this.Controls.Add(this.nascimentoDateTimePicker);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoTextBox);
            this.Controls.Add(sexoLabel);
            this.Controls.Add(this.sexoTextBox);
            this.Controls.Add(telefone_1Label);
            this.Controls.Add(this.telefone_1TextBox);
            this.Controls.Add(telefone_2Label);
            this.Controls.Add(this.telefone_2TextBox);
            this.Controls.Add(this.cadastroBindingNavigator);
            this.Name = "Formulario";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaContatoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroBindingNavigator)).EndInit();
            this.cadastroBindingNavigator.ResumeLayout(false);
            this.cadastroBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private listaContatoDBDataSet listaContatoDBDataSet;
        private System.Windows.Forms.BindingSource cadastroBindingSource;
        private listaContatoDBDataSetTableAdapters.CadastroTableAdapter cadastroTableAdapter;
        private listaContatoDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cadastroBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cadastroBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox sobrenomeTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.DateTimePicker nascimentoDateTimePicker;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.TextBox sexoTextBox;
        private System.Windows.Forms.TextBox telefone_1TextBox;
        private System.Windows.Forms.TextBox telefone_2TextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

