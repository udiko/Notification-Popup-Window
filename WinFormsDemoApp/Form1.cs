﻿using System;
using Tulpep.NotificationWindow;
using System.Windows.Forms;

namespace WinFormsDemoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnShow_Click(object sender, EventArgs e)
        {
            PopupNotifier popupNotifier1 = new PopupNotifier();

            popupNotifier1.TitleText = txtTitle.Text;
            popupNotifier1.ContentText = txtText.Text;
            popupNotifier1.ShowCloseButton = chkClose.Checked;
            popupNotifier1.ShowOptionsButton = chkMenu.Checked;
            popupNotifier1.ShowGrip = chkGrip.Checked;
            popupNotifier1.Delay = int.Parse(txtDelay.Text);
            popupNotifier1.AnimationInterval = int.Parse(txtInterval.Text);
            popupNotifier1.AnimationDuration = int.Parse(txtAnimationDuration.Text);
            popupNotifier1.TitlePadding = new Padding(int.Parse(txtPaddingTitle.Text));
            popupNotifier1.ContentPadding = new Padding(int.Parse(txtPaddingContent.Text));
            popupNotifier1.ImagePadding = new Padding(int.Parse(txtPaddingIcon.Text));
            popupNotifier1.Scroll = chkScroll.Checked;
            popupNotifier1.IsRightToLeft = chkIsRightToLeft.Checked;
            if (chkIcon.Checked)
            {
                popupNotifier1.Image = Resources._157_GetPermission_48x48_72;
            }
            else
            {
                popupNotifier1.Image = null;
            }

            popupNotifier1.Popup();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }


    }
}
