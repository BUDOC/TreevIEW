
namespace TreeView
{
  partial class Form1
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprimerLeNoeudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insérerUnNoeudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renimmerLeNoeudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propriétésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficheLeParentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficheEnfantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trouveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trouveNoeudContenantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btSaveTreeview = new System.Windows.Forms.Button();
            this.bt_GetBackTreeview = new System.Windows.Forms.Button();
            this.btSeeTree = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btSaveTree = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btTreeFromTextFile = new System.Windows.Forms.Button();
            this.btDevelopper = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.treeView1.LineColor = System.Drawing.Color.Maroon;
            this.treeView1.Location = new System.Drawing.Point(21, 42);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(593, 386);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerLeNoeudToolStripMenuItem,
            this.insérerUnNoeudToolStripMenuItem,
            this.renimmerLeNoeudToolStripMenuItem,
            this.propriétésToolStripMenuItem,
            this.afficheLeParentToolStripMenuItem,
            this.afficheEnfantsToolStripMenuItem,
            this.trouveToolStripMenuItem,
            this.trouveNoeudContenantToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(246, 196);
            this.contextMenuStrip1.Text = "Menu";
            // 
            // supprimerLeNoeudToolStripMenuItem
            // 
            this.supprimerLeNoeudToolStripMenuItem.Name = "supprimerLeNoeudToolStripMenuItem";
            this.supprimerLeNoeudToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.supprimerLeNoeudToolStripMenuItem.Text = "Supprimer le noeud";
            this.supprimerLeNoeudToolStripMenuItem.Click += new System.EventHandler(this.supprimerLeNoeudToolStripMenuItem_Click);
            // 
            // insérerUnNoeudToolStripMenuItem
            // 
            this.insérerUnNoeudToolStripMenuItem.Name = "insérerUnNoeudToolStripMenuItem";
            this.insérerUnNoeudToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.insérerUnNoeudToolStripMenuItem.Text = "Insérer un noeud";
            this.insérerUnNoeudToolStripMenuItem.Click += new System.EventHandler(this.insérerUnNoeudToolStripMenuItem_Click);
            // 
            // renimmerLeNoeudToolStripMenuItem
            // 
            this.renimmerLeNoeudToolStripMenuItem.Name = "renimmerLeNoeudToolStripMenuItem";
            this.renimmerLeNoeudToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.renimmerLeNoeudToolStripMenuItem.Text = "Renommer le noeud";
            this.renimmerLeNoeudToolStripMenuItem.Click += new System.EventHandler(this.RenemmerLeNoeudToolStripMenuItem_Click);
            // 
            // propriétésToolStripMenuItem
            // 
            this.propriétésToolStripMenuItem.Name = "propriétésToolStripMenuItem";
            this.propriétésToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.propriétésToolStripMenuItem.Text = "Propriétés";
            this.propriétésToolStripMenuItem.Click += new System.EventHandler(this.propriétésToolStripMenuItem_Click);
            // 
            // afficheLeParentToolStripMenuItem
            // 
            this.afficheLeParentToolStripMenuItem.Name = "afficheLeParentToolStripMenuItem";
            this.afficheLeParentToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.afficheLeParentToolStripMenuItem.Text = "Affiche le parent";
            this.afficheLeParentToolStripMenuItem.Click += new System.EventHandler(this.afficheLeParentToolStripMenuItem_Click);
            // 
            // afficheEnfantsToolStripMenuItem
            // 
            this.afficheEnfantsToolStripMenuItem.Name = "afficheEnfantsToolStripMenuItem";
            this.afficheEnfantsToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.afficheEnfantsToolStripMenuItem.Text = "Affiche enfants";
            this.afficheEnfantsToolStripMenuItem.Click += new System.EventHandler(this.afficheEnfantsToolStripMenuItem_Click);
            // 
            // trouveToolStripMenuItem
            // 
            this.trouveToolStripMenuItem.Name = "trouveToolStripMenuItem";
            this.trouveToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.trouveToolStripMenuItem.Text = "Trouve Noeud par Clé ";
            this.trouveToolStripMenuItem.Click += new System.EventHandler(this.trouveToolStripMenuItem_Click);
            this.trouveToolStripMenuItem.MouseHover += new System.EventHandler(this.trouveToolStripMenuItem_MouseHover);
            // 
            // trouveNoeudContenantToolStripMenuItem
            // 
            this.trouveNoeudContenantToolStripMenuItem.Name = "trouveNoeudContenantToolStripMenuItem";
            this.trouveNoeudContenantToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.trouveNoeudContenantToolStripMenuItem.Text = "Trouve Noeud contenant ";
            this.trouveNoeudContenantToolStripMenuItem.Click += new System.EventHandler(this.trouveNoeudContenantToolStripMenuItem_Click);
            this.trouveNoeudContenantToolStripMenuItem.MouseHover += new System.EventHandler(this.trouveNoeudContenantToolStripMenuItem_MouseHover);
            // 
            // treeView2
            // 
            this.treeView2.BackColor = System.Drawing.SystemColors.Info;
            this.treeView2.Location = new System.Drawing.Point(632, 39);
            this.treeView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(270, 386);
            this.treeView2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Treeview1 Clic droit pour menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(629, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Treeview2";
            // 
            // btSaveTreeview
            // 
            this.btSaveTreeview.Location = new System.Drawing.Point(937, 78);
            this.btSaveTreeview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSaveTreeview.Name = "btSaveTreeview";
            this.btSaveTreeview.Size = new System.Drawing.Size(243, 37);
            this.btSaveTreeview.TabIndex = 6;
            this.btSaveTreeview.Text = "Enregistre Treeview1";
            this.btSaveTreeview.UseVisualStyleBackColor = true;
            this.btSaveTreeview.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_GetBackTreeview
            // 
            this.bt_GetBackTreeview.Location = new System.Drawing.Point(937, 129);
            this.bt_GetBackTreeview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_GetBackTreeview.Name = "bt_GetBackTreeview";
            this.bt_GetBackTreeview.Size = new System.Drawing.Size(243, 38);
            this.bt_GetBackTreeview.TabIndex = 7;
            this.bt_GetBackTreeview.Text = "Rappel fichier dans treeView2";
            this.bt_GetBackTreeview.UseVisualStyleBackColor = true;
            this.bt_GetBackTreeview.Click += new System.EventHandler(this.button3_Click);
            // 
            // btSeeTree
            // 
            this.btSeeTree.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btSeeTree.Location = new System.Drawing.Point(937, 10);
            this.btSeeTree.Name = "btSeeTree";
            this.btSeeTree.Size = new System.Drawing.Size(243, 45);
            this.btSeeTree.TabIndex = 14;
            this.btSeeTree.Text = "Affiche l\'arbre";
            this.btSeeTree.UseVisualStyleBackColor = true;
            this.btSeeTree.Click += new System.EventHandler(this.btSeeTree_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 447);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1227, 26);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LabelStatus
            // 
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(147, 20);
            this.LabelStatus.Text = "Exemple de treeview";
            // 
            // btSaveTree
            // 
            this.btSaveTree.Location = new System.Drawing.Point(937, 215);
            this.btSaveTree.Name = "btSaveTree";
            this.btSaveTree.Size = new System.Drawing.Size(237, 43);
            this.btSaveTree.TabIndex = 16;
            this.btSaveTree.Text = "Enregistrer Arbre / support";
            this.btSaveTree.UseVisualStyleBackColor = true;
            this.btSaveTree.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(937, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 43);
            this.button1.TabIndex = 17;
            this.button1.Text = "Rappel Arbre / support";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btTreeFromTextFile
            // 
            this.btTreeFromTextFile.Location = new System.Drawing.Point(937, 329);
            this.btTreeFromTextFile.Name = "btTreeFromTextFile";
            this.btTreeFromTextFile.Size = new System.Drawing.Size(237, 43);
            this.btTreeFromTextFile.TabIndex = 18;
            this.btTreeFromTextFile.Text = "Construction Arbre depuis ficj=hier texte";
            this.btTreeFromTextFile.UseVisualStyleBackColor = true;
            this.btTreeFromTextFile.Click += new System.EventHandler(this.btTreeFromTextFile_Click);
            // 
            // btDevelopper
            // 
            this.btDevelopper.Location = new System.Drawing.Point(937, 391);
            this.btDevelopper.Name = "btDevelopper";
            this.btDevelopper.Size = new System.Drawing.Size(242, 34);
            this.btDevelopper.TabIndex = 19;
            this.btDevelopper.Text = "Developper Arbre";
            this.btDevelopper.UseVisualStyleBackColor = true;
            this.btDevelopper.Click += new System.EventHandler(this.btDevelopper_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 473);
            this.Controls.Add(this.btDevelopper);
            this.Controls.Add(this.btTreeFromTextFile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btSaveTree);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btSeeTree);
            this.Controls.Add(this.bt_GetBackTreeview);
            this.Controls.Add(this.btSaveTreeview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.treeView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TreeView treeView1;
    private System.Windows.Forms.TreeView treeView2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btSaveTreeview;
    private System.Windows.Forms.Button bt_GetBackTreeview;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem supprimerLeNoeudToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem insérerUnNoeudToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem renimmerLeNoeudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propriétésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficheLeParentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficheEnfantsToolStripMenuItem;
        private System.Windows.Forms.Button btSeeTree;
        private System.Windows.Forms.ToolStripMenuItem trouveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trouveNoeudContenantToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LabelStatus;
        private System.Windows.Forms.Button btSaveTree;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btTreeFromTextFile;
        private System.Windows.Forms.Button btDevelopper;
    }
}

