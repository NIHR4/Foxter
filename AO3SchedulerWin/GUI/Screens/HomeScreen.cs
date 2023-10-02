﻿using AO3SchedulerWin.Controllers.AuthorControllers;
using AO3SchedulerWin.Controllers.StoryControllers;
using AO3SchedulerWin.Models.AuthorModels;
using AO3SchedulerWin.Models.StoryModels;
using AO3SchedulerWin.Views.AuthorViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AO3SchedulerWin.Forms
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
            //TODO: Dependy Injection this
            var model = new AuthorLocalModel();
            _authorController = new LoggedAuthorController(model, new AuthorNameView(authorLabel));
            _queuedStoriesController = new StoryQueueController(new LocalStoryModel(), queueLabel);

        }

        protected override void OnLoad(EventArgs e)
        {
            _authorController.UpdateViews();
            _queuedStoriesController.UpdateViews();

        }

        private IAuthorController _authorController;
        private IStoryController _queuedStoriesController;
    }
}
