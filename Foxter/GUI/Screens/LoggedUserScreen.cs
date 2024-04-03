﻿using Foxter.AO3;
using Foxter.Controllers.AuthorControllers;
using Foxter.GUI.Forms;
using Foxter.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foxter.GUI.Screens
{
    public partial class LoggedUserScreen : Form
    {
        private IAuthorController _authorDisplayController;
        private IAuthorController _authroController;
        private Ao3Session _session;
        private IScreenUpdater _updater;
        public LoggedUserScreen(ref Ao3Session session, IAuthorModel authorModel, IScreenUpdater updater)
        {
            InitializeComponent();
            _authorDisplayController = new DisplayAuthorController(authorModel, authorLabel);
            _authroController = new LoginAuthorController(authorModel);
            _session = session;
            _updater = updater;
        }

        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            await _authorDisplayController.UpdateViews();
        }

        private async void logoutButton_Click(object sender, EventArgs e)
        {
            await _authroController.UnregisterAuthor();
            _session.Reset();
            _updater.ChangeScreen(ScreenId.LOGIN);
        }
    }
}