namespace BaseCRUDWindowsFomsDataBaseCSharp
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            dgPessoa = new DataGridView();
            lbID = new Label();
            tbID = new TextBox();
            tbNome = new TextBox();
            lbNome = new Label();
            tbTpDocto = new TextBox();
            lbTpDocto = new Label();
            tbDocto = new TextBox();
            lbDocto = new Label();
            tbTelefone = new TextBox();
            lbTelefone = new Label();
            toolStrip1 = new ToolStrip();
            tsbNew = new ToolStripButton();
            tsbEdit = new ToolStripButton();
            tsbSave = new ToolStripButton();
            tsbCancel = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            tsbDelete = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tstbSearch = new ToolStripTextBox();
            tsbSearch = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dgPessoa).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgPessoa
            // 
            dgPessoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPessoa.Location = new Point(-7, 384);
            dgPessoa.Name = "dgPessoa";
            dgPessoa.RowHeadersWidth = 51;
            dgPessoa.RowTemplate.Height = 29;
            dgPessoa.Size = new Size(1339, 276);
            dgPessoa.TabIndex = 0;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(23, 24);
            lbID.Name = "lbID";
            lbID.Size = new Size(24, 20);
            lbID.TabIndex = 1;
            lbID.Text = "ID";
            // 
            // tbID
            // 
            tbID.Location = new Point(23, 47);
            tbID.Name = "tbID";
            tbID.Size = new Size(125, 27);
            tbID.TabIndex = 2;
            // 
            // tbNome
            // 
            tbNome.Location = new Point(23, 102);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(125, 27);
            tbNome.TabIndex = 4;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(23, 79);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(50, 20);
            lbNome.TabIndex = 3;
            lbNome.Text = "Nome";
            // 
            // tbTpDocto
            // 
            tbTpDocto.Location = new Point(23, 159);
            tbTpDocto.Name = "tbTpDocto";
            tbTpDocto.Size = new Size(125, 27);
            tbTpDocto.TabIndex = 6;
            // 
            // lbTpDocto
            // 
            lbTpDocto.AutoSize = true;
            lbTpDocto.Location = new Point(23, 136);
            lbTpDocto.Name = "lbTpDocto";
            lbTpDocto.Size = new Size(70, 20);
            lbTpDocto.TabIndex = 5;
            lbTpDocto.Text = "Tp Docto";
            // 
            // tbDocto
            // 
            tbDocto.Location = new Point(23, 219);
            tbDocto.Name = "tbDocto";
            tbDocto.Size = new Size(125, 27);
            tbDocto.TabIndex = 8;
            // 
            // lbDocto
            // 
            lbDocto.AutoSize = true;
            lbDocto.Location = new Point(23, 196);
            lbDocto.Name = "lbDocto";
            lbDocto.Size = new Size(50, 20);
            lbDocto.TabIndex = 7;
            lbDocto.Text = "Docto";
            // 
            // tbTelefone
            // 
            tbTelefone.Location = new Point(23, 282);
            tbTelefone.Name = "tbTelefone";
            tbTelefone.Size = new Size(125, 27);
            tbTelefone.TabIndex = 10;
            // 
            // lbTelefone
            // 
            lbTelefone.AutoSize = true;
            lbTelefone.Location = new Point(23, 259);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new Size(66, 20);
            lbTelefone.TabIndex = 9;
            lbTelefone.Text = "Telefone";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNew, tsbEdit, tsbSave, tsbCancel, toolStripSeparator, tsbDelete, toolStripSeparator1, tstbSearch, tsbSearch });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1334, 27);
            toolStrip1.TabIndex = 16;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // tsbNew
            // 
            tsbNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbNew.Image = (Image)resources.GetObject("tsbNew.Image");
            tsbNew.ImageTransparentColor = Color.Magenta;
            tsbNew.Name = "tsbNew";
            tsbNew.Size = new Size(29, 24);
            tsbNew.Text = "&Novo";
            // 
            // tsbEdit
            // 
            tsbEdit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbEdit.Image = (Image)resources.GetObject("tsbEdit.Image");
            tsbEdit.ImageTransparentColor = Color.Magenta;
            tsbEdit.Name = "tsbEdit";
            tsbEdit.Size = new Size(29, 24);
            tsbEdit.Text = "&Editar";
            tsbEdit.Click += tsbEdit_Click;
            // 
            // tsbSave
            // 
            tsbSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbSave.Image = (Image)resources.GetObject("tsbSave.Image");
            tsbSave.ImageTransparentColor = Color.Magenta;
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new Size(29, 24);
            tsbSave.Text = "&Salvar";
            // 
            // tsbCancel
            // 
            tsbCancel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbCancel.Image = (Image)resources.GetObject("tsbCancel.Image");
            tsbCancel.ImageTransparentColor = Color.Magenta;
            tsbCancel.Name = "tsbCancel";
            tsbCancel.Size = new Size(29, 24);
            tsbCancel.Text = "&Cancelar";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 27);
            // 
            // tsbDelete
            // 
            tsbDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbDelete.Image = (Image)resources.GetObject("tsbDelete.Image");
            tsbDelete.ImageTransparentColor = Color.Magenta;
            tsbDelete.Name = "tsbDelete";
            tsbDelete.Size = new Size(29, 24);
            tsbDelete.Text = "&Deletar";
            tsbDelete.Click += tsbDelete_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // tstbSearch
            // 
            tstbSearch.Name = "tstbSearch";
            tstbSearch.Size = new Size(100, 27);
            // 
            // tsbSearch
            // 
            tsbSearch.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbSearch.Image = (Image)resources.GetObject("tsbSearch.Image");
            tsbSearch.ImageTransparentColor = Color.Magenta;
            tsbSearch.Name = "tsbSearch";
            tsbSearch.Size = new Size(29, 24);
            tsbSearch.Text = "tsbSearch";
            tsbSearch.Click += tsbSearch_Click;
            // 
            // frmCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 661);
            Controls.Add(toolStrip1);
            Controls.Add(tbTelefone);
            Controls.Add(lbTelefone);
            Controls.Add(tbDocto);
            Controls.Add(lbDocto);
            Controls.Add(tbTpDocto);
            Controls.Add(lbTpDocto);
            Controls.Add(tbNome);
            Controls.Add(lbNome);
            Controls.Add(tbID);
            Controls.Add(lbID);
            Controls.Add(dgPessoa);
            Name = "frmCliente";
            Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)dgPessoa).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgPessoa;
        private Label lbID;
        private TextBox tbID;
        private TextBox tbNome;
        private Label lbNome;
        private TextBox tbTpDocto;
        private Label lbTpDocto;
        private TextBox tbDocto;
        private Label lbDocto;
        private TextBox tbTelefone;
        private Label lbTelefone;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbNew;
        private ToolStripButton tsbEdit;
        private ToolStripButton tsbSave;
        private ToolStripButton tsbCancel;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton tsbDelete;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbSearch;
        private ToolStripTextBox tstbSearch;
    }
}