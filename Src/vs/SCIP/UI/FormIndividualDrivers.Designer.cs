﻿namespace UI
{
    partial class FormIndividualDrivers
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            this.LabelCompkey = new Infragistics.Win.Misc.UltraLabel();
            this.TextEditorCompkey = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.LabelDriverType = new Infragistics.Win.Misc.UltraLabel();
            this.LabelOverrideCost = new Infragistics.Win.Misc.UltraLabel();
            this.labelOverrideFrequency = new Infragistics.Win.Misc.UltraLabel();
            this.labelDriversForThisCompkey = new Infragistics.Win.Misc.UltraLabel();
            this.ultraGrid1 = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraDropDown1 = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditorCompkey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelCompkey
            // 
            this.LabelCompkey.Location = new System.Drawing.Point(220, 14);
            this.LabelCompkey.Name = "LabelCompkey";
            this.LabelCompkey.Size = new System.Drawing.Size(158, 19);
            this.LabelCompkey.TabIndex = 0;
            this.LabelCompkey.Text = "Updating Driver for Compkey:";
            // 
            // TextEditorCompkey
            // 
            this.TextEditorCompkey.Location = new System.Drawing.Point(385, 14);
            this.TextEditorCompkey.Name = "TextEditorCompkey";
            this.TextEditorCompkey.Size = new System.Drawing.Size(100, 21);
            this.TextEditorCompkey.TabIndex = 1;
            this.TextEditorCompkey.Text = "COMPKEY";
            // 
            // LabelDriverType
            // 
            this.LabelDriverType.Location = new System.Drawing.Point(21, 64);
            this.LabelDriverType.Name = "LabelDriverType";
            this.LabelDriverType.Size = new System.Drawing.Size(109, 19);
            this.LabelDriverType.TabIndex = 2;
            this.LabelDriverType.Text = "Driver Type:";
            // 
            // LabelOverrideCost
            // 
            this.LabelOverrideCost.Location = new System.Drawing.Point(21, 89);
            this.LabelOverrideCost.Name = "LabelOverrideCost";
            this.LabelOverrideCost.Size = new System.Drawing.Size(109, 19);
            this.LabelOverrideCost.TabIndex = 3;
            this.LabelOverrideCost.Text = "Override Cost:";
            // 
            // labelOverrideFrequency
            // 
            this.labelOverrideFrequency.Location = new System.Drawing.Point(21, 114);
            this.labelOverrideFrequency.Name = "labelOverrideFrequency";
            this.labelOverrideFrequency.Size = new System.Drawing.Size(109, 19);
            this.labelOverrideFrequency.TabIndex = 4;
            this.labelOverrideFrequency.Text = "Override Frequency:";
            // 
            // labelDriversForThisCompkey
            // 
            this.labelDriversForThisCompkey.Location = new System.Drawing.Point(220, 164);
            this.labelDriversForThisCompkey.Name = "labelDriversForThisCompkey";
            this.labelDriversForThisCompkey.Size = new System.Drawing.Size(164, 19);
            this.labelDriversForThisCompkey.TabIndex = 5;
            this.labelDriversForThisCompkey.Text = "Drivers for this Compkey:";
            // 
            // ultraGrid1
            // 
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.ultraGrid1.DisplayLayout.Appearance = appearance1;
            this.ultraGrid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraGrid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance2.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraGrid1.DisplayLayout.GroupByBox.Appearance = appearance2;
            appearance3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraGrid1.DisplayLayout.GroupByBox.BandLabelAppearance = appearance3;
            this.ultraGrid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance4.BackColor2 = System.Drawing.SystemColors.Control;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraGrid1.DisplayLayout.GroupByBox.PromptAppearance = appearance4;
            this.ultraGrid1.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraGrid1.DisplayLayout.MaxRowScrollRegions = 1;
            appearance5.BackColor = System.Drawing.SystemColors.Window;
            appearance5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ultraGrid1.DisplayLayout.Override.ActiveCellAppearance = appearance5;
            appearance6.BackColor = System.Drawing.SystemColors.Highlight;
            appearance6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ultraGrid1.DisplayLayout.Override.ActiveRowAppearance = appearance6;
            this.ultraGrid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ultraGrid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance7.BackColor = System.Drawing.SystemColors.Window;
            this.ultraGrid1.DisplayLayout.Override.CardAreaAppearance = appearance7;
            appearance8.BorderColor = System.Drawing.Color.Silver;
            appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.ultraGrid1.DisplayLayout.Override.CellAppearance = appearance8;
            this.ultraGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.ultraGrid1.DisplayLayout.Override.CellPadding = 0;
            appearance9.BackColor = System.Drawing.SystemColors.Control;
            appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance9.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraGrid1.DisplayLayout.Override.GroupByRowAppearance = appearance9;
            appearance10.TextHAlignAsString = "Left";
            this.ultraGrid1.DisplayLayout.Override.HeaderAppearance = appearance10;
            this.ultraGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ultraGrid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance11.BackColor = System.Drawing.SystemColors.Window;
            appearance11.BorderColor = System.Drawing.Color.Silver;
            this.ultraGrid1.DisplayLayout.Override.RowAppearance = appearance11;
            this.ultraGrid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ultraGrid1.DisplayLayout.Override.TemplateAddRowAppearance = appearance12;
            this.ultraGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraGrid1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraGrid1.Location = new System.Drawing.Point(41, 195);
            this.ultraGrid1.Name = "ultraGrid1";
            this.ultraGrid1.Size = new System.Drawing.Size(550, 80);
            this.ultraGrid1.TabIndex = 6;
            this.ultraGrid1.Text = "ultraGrid1";
            // 
            // ultraDropDown1
            // 
            appearance13.BackColor = System.Drawing.SystemColors.Window;
            appearance13.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.ultraDropDown1.DisplayLayout.Appearance = appearance13;
            this.ultraDropDown1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraDropDown1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance14.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance14.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraDropDown1.DisplayLayout.GroupByBox.Appearance = appearance14;
            appearance15.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraDropDown1.DisplayLayout.GroupByBox.BandLabelAppearance = appearance15;
            this.ultraDropDown1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance16.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance16.BackColor2 = System.Drawing.SystemColors.Control;
            appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance16.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraDropDown1.DisplayLayout.GroupByBox.PromptAppearance = appearance16;
            this.ultraDropDown1.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraDropDown1.DisplayLayout.MaxRowScrollRegions = 1;
            appearance17.BackColor = System.Drawing.SystemColors.Window;
            appearance17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ultraDropDown1.DisplayLayout.Override.ActiveCellAppearance = appearance17;
            appearance18.BackColor = System.Drawing.SystemColors.Highlight;
            appearance18.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ultraDropDown1.DisplayLayout.Override.ActiveRowAppearance = appearance18;
            this.ultraDropDown1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ultraDropDown1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance19.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDown1.DisplayLayout.Override.CardAreaAppearance = appearance19;
            appearance20.BorderColor = System.Drawing.Color.Silver;
            appearance20.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.ultraDropDown1.DisplayLayout.Override.CellAppearance = appearance20;
            this.ultraDropDown1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.ultraDropDown1.DisplayLayout.Override.CellPadding = 0;
            appearance21.BackColor = System.Drawing.SystemColors.Control;
            appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance21.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance21.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraDropDown1.DisplayLayout.Override.GroupByRowAppearance = appearance21;
            appearance22.TextHAlignAsString = "Left";
            this.ultraDropDown1.DisplayLayout.Override.HeaderAppearance = appearance22;
            this.ultraDropDown1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ultraDropDown1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance23.BackColor = System.Drawing.SystemColors.Window;
            appearance23.BorderColor = System.Drawing.Color.Silver;
            this.ultraDropDown1.DisplayLayout.Override.RowAppearance = appearance23;
            this.ultraDropDown1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance24.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ultraDropDown1.DisplayLayout.Override.TemplateAddRowAppearance = appearance24;
            this.ultraDropDown1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraDropDown1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraDropDown1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDown1.Location = new System.Drawing.Point(137, 64);
            this.ultraDropDown1.Name = "ultraDropDown1";
            this.ultraDropDown1.Size = new System.Drawing.Size(424, 80);
            this.ultraDropDown1.TabIndex = 7;
            this.ultraDropDown1.Text = "ultraDropDown1";
            this.ultraDropDown1.Visible = false;
            // 
            // FormIndividualDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 309);
            this.Controls.Add(this.ultraDropDown1);
            this.Controls.Add(this.ultraGrid1);
            this.Controls.Add(this.labelDriversForThisCompkey);
            this.Controls.Add(this.labelOverrideFrequency);
            this.Controls.Add(this.LabelOverrideCost);
            this.Controls.Add(this.LabelDriverType);
            this.Controls.Add(this.TextEditorCompkey);
            this.Controls.Add(this.LabelCompkey);
            this.Name = "FormIndividualDrivers";
            this.Text = "Individual Drivers";
            ((System.ComponentModel.ISupportInitialize)(this.TextEditorCompkey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.Misc.UltraLabel LabelCompkey;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor TextEditorCompkey;
        private Infragistics.Win.Misc.UltraLabel LabelDriverType;
        private Infragistics.Win.Misc.UltraLabel LabelOverrideCost;
        private Infragistics.Win.Misc.UltraLabel labelOverrideFrequency;
        private Infragistics.Win.Misc.UltraLabel labelDriversForThisCompkey;
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGrid1;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDown1;
    }
}