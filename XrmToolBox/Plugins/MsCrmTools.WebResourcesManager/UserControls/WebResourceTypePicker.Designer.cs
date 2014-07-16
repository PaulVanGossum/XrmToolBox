﻿namespace MsCrmTools.WebResourcesManager.UserControls
{
    partial class WebResourceTypePicker
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkIco = new System.Windows.Forms.CheckBox();
            this.chkXsl = new System.Windows.Forms.CheckBox();
            this.chkXap = new System.Windows.Forms.CheckBox();
            this.chkGif = new System.Windows.Forms.CheckBox();
            this.chkJpeg = new System.Windows.Forms.CheckBox();
            this.chkPng = new System.Windows.Forms.CheckBox();
            this.chkXml = new System.Windows.Forms.CheckBox();
            this.chkJavaScript = new System.Windows.Forms.CheckBox();
            this.chkCss = new System.Windows.Forms.CheckBox();
            this.chkHtml = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chkIco);
            this.groupBox2.Controls.Add(this.chkXsl);
            this.groupBox2.Controls.Add(this.chkXap);
            this.groupBox2.Controls.Add(this.chkGif);
            this.groupBox2.Controls.Add(this.chkJpeg);
            this.groupBox2.Controls.Add(this.chkPng);
            this.groupBox2.Controls.Add(this.chkXml);
            this.groupBox2.Controls.Add(this.chkJavaScript);
            this.groupBox2.Controls.Add(this.chkCss);
            this.groupBox2.Controls.Add(this.chkHtml);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Load only these file types";
            // 
            // chkIco
            // 
            this.chkIco.AutoSize = true;
            this.chkIco.Checked = true;
            this.chkIco.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIco.Location = new System.Drawing.Point(338, 19);
            this.chkIco.Name = "chkIco";
            this.chkIco.Size = new System.Drawing.Size(44, 17);
            this.chkIco.TabIndex = 9;
            this.chkIco.Tag = ".ico";
            this.chkIco.Text = "ICO";
            this.chkIco.UseVisualStyleBackColor = true;
            // 
            // chkXsl
            // 
            this.chkXsl.AutoSize = true;
            this.chkXsl.Checked = true;
            this.chkXsl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkXsl.Location = new System.Drawing.Point(242, 65);
            this.chkXsl.Name = "chkXsl";
            this.chkXsl.Size = new System.Drawing.Size(46, 17);
            this.chkXsl.TabIndex = 8;
            this.chkXsl.Tag = ".xsl|.xslt";
            this.chkXsl.Text = "XSL";
            this.chkXsl.UseVisualStyleBackColor = true;
            // 
            // chkXap
            // 
            this.chkXap.AutoSize = true;
            this.chkXap.Checked = true;
            this.chkXap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkXap.Location = new System.Drawing.Point(242, 42);
            this.chkXap.Name = "chkXap";
            this.chkXap.Size = new System.Drawing.Size(47, 17);
            this.chkXap.TabIndex = 7;
            this.chkXap.Tag = ".xap";
            this.chkXap.Text = "XAP";
            this.chkXap.UseVisualStyleBackColor = true;
            // 
            // chkGif
            // 
            this.chkGif.AutoSize = true;
            this.chkGif.Checked = true;
            this.chkGif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGif.Location = new System.Drawing.Point(242, 19);
            this.chkGif.Name = "chkGif";
            this.chkGif.Size = new System.Drawing.Size(43, 17);
            this.chkGif.TabIndex = 6;
            this.chkGif.Tag = ".gif";
            this.chkGif.Text = "GIF";
            this.chkGif.UseVisualStyleBackColor = true;
            // 
            // chkJpeg
            // 
            this.chkJpeg.AutoSize = true;
            this.chkJpeg.Checked = true;
            this.chkJpeg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJpeg.Location = new System.Drawing.Point(116, 65);
            this.chkJpeg.Name = "chkJpeg";
            this.chkJpeg.Size = new System.Drawing.Size(78, 17);
            this.chkJpeg.TabIndex = 5;
            this.chkJpeg.Tag = ".jpg|.jpeg";
            this.chkJpeg.Text = "JPG/JPEG";
            this.chkJpeg.UseVisualStyleBackColor = true;
            // 
            // chkPng
            // 
            this.chkPng.AutoSize = true;
            this.chkPng.Checked = true;
            this.chkPng.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPng.Location = new System.Drawing.Point(116, 42);
            this.chkPng.Name = "chkPng";
            this.chkPng.Size = new System.Drawing.Size(49, 17);
            this.chkPng.TabIndex = 4;
            this.chkPng.Tag = ".png";
            this.chkPng.Text = "PNG";
            this.chkPng.UseVisualStyleBackColor = true;
            // 
            // chkXml
            // 
            this.chkXml.AutoSize = true;
            this.chkXml.Checked = true;
            this.chkXml.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkXml.Location = new System.Drawing.Point(116, 19);
            this.chkXml.Name = "chkXml";
            this.chkXml.Size = new System.Drawing.Size(48, 17);
            this.chkXml.TabIndex = 3;
            this.chkXml.Tag = ".xml";
            this.chkXml.Text = "XML";
            this.chkXml.UseVisualStyleBackColor = true;
            // 
            // chkJavaScript
            // 
            this.chkJavaScript.AutoSize = true;
            this.chkJavaScript.Checked = true;
            this.chkJavaScript.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJavaScript.Location = new System.Drawing.Point(6, 65);
            this.chkJavaScript.Name = "chkJavaScript";
            this.chkJavaScript.Size = new System.Drawing.Size(38, 17);
            this.chkJavaScript.TabIndex = 2;
            this.chkJavaScript.Tag = ".js";
            this.chkJavaScript.Text = "JS";
            this.chkJavaScript.UseVisualStyleBackColor = true;
            // 
            // chkCss
            // 
            this.chkCss.AutoSize = true;
            this.chkCss.Checked = true;
            this.chkCss.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCss.Location = new System.Drawing.Point(6, 42);
            this.chkCss.Name = "chkCss";
            this.chkCss.Size = new System.Drawing.Size(47, 17);
            this.chkCss.TabIndex = 1;
            this.chkCss.Tag = ".css";
            this.chkCss.Text = "CSS";
            this.chkCss.UseVisualStyleBackColor = true;
            // 
            // chkHtml
            // 
            this.chkHtml.AutoSize = true;
            this.chkHtml.Checked = true;
            this.chkHtml.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHtml.Location = new System.Drawing.Point(6, 19);
            this.chkHtml.Name = "chkHtml";
            this.chkHtml.Size = new System.Drawing.Size(56, 17);
            this.chkHtml.TabIndex = 0;
            this.chkHtml.Tag = ".html";
            this.chkHtml.Text = "HTML";
            this.chkHtml.UseVisualStyleBackColor = true;
            // 
            // WebResourceTypePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Name = "WebResourceTypePicker";
            this.Size = new System.Drawing.Size(460, 100);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkIco;
        private System.Windows.Forms.CheckBox chkXsl;
        private System.Windows.Forms.CheckBox chkXap;
        private System.Windows.Forms.CheckBox chkGif;
        private System.Windows.Forms.CheckBox chkJpeg;
        private System.Windows.Forms.CheckBox chkPng;
        private System.Windows.Forms.CheckBox chkXml;
        private System.Windows.Forms.CheckBox chkJavaScript;
        private System.Windows.Forms.CheckBox chkCss;
        private System.Windows.Forms.CheckBox chkHtml;

    }
}