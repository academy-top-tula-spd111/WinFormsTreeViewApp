namespace WinFormsTreeViewApp
{
    public partial class Form1 : Form
    {
        bool expandTree;
        public Form1()
        {
            InitializeComponent();

            TreeNode node = new TreeNode();
            node.Text = "Перефирийные устройства";
            TreeNode nodePrinter = new TreeNode();
            TreeNode nodeScanner = new TreeNode();
            nodePrinter.Text = "Принтеры";
            nodeScanner.Text = "Сканеры";
            node.Nodes.AddRange(new TreeNode[] 
                        { nodePrinter, nodeScanner });

            TreeNode nodeProducts = treeProducts.Nodes.Find("nodeProducts", true)[0];
            nodeProducts.Nodes.AddRange(new TreeNode[] { node });


            FillDriveNodes();

        }

        private void btnExpandToggle_Click(object sender, EventArgs e)
        {
            TreeNode currentNode = treeProducts.SelectedNode;
            if(currentNode.IsExpanded)
                currentNode.Collapse();
            else
                currentNode.Expand();
            treeProducts.SelectedNode = currentNode;
            treeProducts.Focus();
        }

        private void btnExpandAll_Click(object sender, EventArgs e)
        {
            if(!expandTree)
                treeProducts.ExpandAll();
            else
                treeProducts.CollapseAll();

            expandTree = !expandTree;
        }

        private void FillDriveNodes()
        {
            foreach(DriveInfo drive in DriveInfo.GetDrives())
            {
                TreeNode node = new TreeNode();
                node.Text = drive.Name;
                FillTreeNode(node, drive.Name);
                treeViewDirs.Nodes.Add(node);
            }
        }

        private void FillTreeNode(TreeNode driveNode, string path)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(path);
                foreach (string dir in dirs)
                {
                    TreeNode node = new();
                    node.Text = dir.Remove(0, dir.LastIndexOf("\\") + 1);
                    driveNode.Nodes.Add(node);
                }
            }
            catch(Exception ex) { }
            
        }

        private void treeViewDirs_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            e.Node?.Nodes.Clear();
            string[] dirs;
            if (Directory.Exists(e.Node?.FullPath))
            {
                dirs = Directory.GetDirectories((string)e.Node.FullPath);
                if (dirs.Length > 0)
                {
                    foreach (string dir in dirs)
                    {
                        TreeNode node = new TreeNode();
                        node.Text = dir.Remove(0, dir.LastIndexOf("\\") + 1);
                        FillTreeNode(node, dir);
                        e.Node.Nodes.Add(node);
                    }
                }
            }
        }

        private void treeViewDirs_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node?.Nodes.Clear();
            string[] dirs;
            if(Directory.Exists(e.Node?.FullPath))
            {
                dirs = Directory.GetDirectories((string)e.Node.FullPath);
                if(dirs.Length > 0) 
                { 
                    foreach(string dir in dirs)
                    {
                        TreeNode node = new TreeNode();
                        node.Text = dir.Remove(0, dir.LastIndexOf("\\") + 1);
                        FillTreeNode(node, dir);
                        e.Node.Nodes.Add(node);
                    }
                }
            }
        }
    }
}