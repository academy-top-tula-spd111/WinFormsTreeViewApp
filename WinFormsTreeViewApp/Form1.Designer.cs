namespace WinFormsTreeViewApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Игровые");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Офисные");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Мультимедийные");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Компьютеры", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Aser");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Ноутбуки", new System.Windows.Forms.TreeNode[] {
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Гаджеты");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Комплектующие");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Товары", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode15,
            treeNode16,
            treeNode17});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeProducts = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.treeViewDirs = new System.Windows.Forms.TreeView();
            this.btnExpandToggle = new System.Windows.Forms.Button();
            this.btnExpandAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeProducts
            // 
            this.treeProducts.ImageIndex = 0;
            this.treeProducts.ImageList = this.imageList1;
            this.treeProducts.Location = new System.Drawing.Point(37, 42);
            this.treeProducts.Name = "treeProducts";
            treeNode10.Name = "Узел5";
            treeNode10.Text = "Игровые";
            treeNode11.Name = "Узел6";
            treeNode11.Text = "Офисные";
            treeNode12.Name = "Узел7";
            treeNode12.Text = "Мультимедийные";
            treeNode13.Name = "Узел1";
            treeNode13.Text = "Компьютеры";
            treeNode14.Name = "Узел8";
            treeNode14.Text = "Aser";
            treeNode15.Name = "Узел2";
            treeNode15.Text = "Ноутбуки";
            treeNode16.Name = "Узел3";
            treeNode16.Text = "Гаджеты";
            treeNode17.Name = "Узел4";
            treeNode17.Text = "Комплектующие";
            treeNode18.Name = "nodeProducts";
            treeNode18.Text = "Товары";
            this.treeProducts.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode18});
            this.treeProducts.SelectedImageIndex = 0;
            this.treeProducts.Size = new System.Drawing.Size(249, 329);
            this.treeProducts.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            // 
            // treeViewDirs
            // 
            this.treeViewDirs.ImageIndex = 0;
            this.treeViewDirs.ImageList = this.imageList1;
            this.treeViewDirs.Location = new System.Drawing.Point(352, 41);
            this.treeViewDirs.Name = "treeViewDirs";
            this.treeViewDirs.SelectedImageIndex = 0;
            this.treeViewDirs.Size = new System.Drawing.Size(384, 329);
            this.treeViewDirs.TabIndex = 1;
            this.treeViewDirs.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewDirs_BeforeExpand);
            this.treeViewDirs.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewDirs_BeforeSelect);
            // 
            // btnExpandToggle
            // 
            this.btnExpandToggle.Location = new System.Drawing.Point(37, 395);
            this.btnExpandToggle.Name = "btnExpandToggle";
            this.btnExpandToggle.Size = new System.Drawing.Size(128, 23);
            this.btnExpandToggle.TabIndex = 2;
            this.btnExpandToggle.Text = "Expand / Collapse";
            this.btnExpandToggle.UseVisualStyleBackColor = true;
            this.btnExpandToggle.Click += new System.EventHandler(this.btnExpandToggle_Click);
            // 
            // btnExpandAll
            // 
            this.btnExpandAll.Location = new System.Drawing.Point(211, 395);
            this.btnExpandAll.Name = "btnExpandAll";
            this.btnExpandAll.Size = new System.Drawing.Size(75, 23);
            this.btnExpandAll.TabIndex = 3;
            this.btnExpandAll.Text = "Expand All";
            this.btnExpandAll.UseVisualStyleBackColor = true;
            this.btnExpandAll.Click += new System.EventHandler(this.btnExpandAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExpandAll);
            this.Controls.Add(this.btnExpandToggle);
            this.Controls.Add(this.treeViewDirs);
            this.Controls.Add(this.treeProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private TreeView treeProducts;
        private ImageList imageList1;
        private TreeView treeViewDirs;
        private Button btnExpandToggle;
        private Button btnExpandAll;
    }
}