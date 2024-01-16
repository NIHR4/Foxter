﻿using AO3SchedulerWin.AO3;
using AO3SchedulerWin.Forms;
using AO3SchedulerWin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AO3SchedulerWin.Views.ChapterViews.TableView
{
    public class ChapterTableItemBuilder : IChapterTableItemBuilder
    {
        private Ao3Client? _ao3Client;
        private IChapterModel? _chapterModel;
        private string? _chapterTitle;
        private int? _databaseId;
        private DateTime? _publishingDate;
        private string? _storyTitle;
        private ITableUpdateListener? _tableListener;

        public bool AllFieldsSet()
        {
            return _ao3Client != null
                && _chapterModel != null
                && _chapterTitle != null
                && _databaseId.HasValue
                && _publishingDate.HasValue
                && _storyTitle != null
                && _tableListener != null;
        }

        public ChapterTableItem Build()
        {
            if (!AllFieldsSet()) {
                throw new Exception("not all fields are set");
            }

            var result =  new ChapterTableItem(
                listener: _tableListener,
                model: _chapterModel,
                session: _ao3Client,
                id: _databaseId.Value,
                storyTitle: _storyTitle,
                chapterTitle: _chapterTitle,
                publishingDate: _publishingDate.Value
            );
            this.Reset();
            return result;
        }

        public void Reset()
        {
            _ao3Client = null;
            _chapterModel = null;
            _chapterTitle = null;
            _databaseId = -1;
            _publishingDate = null;
        }

        //Setters
        public IChapterTableItemBuilder SetAo3Client(Ao3Client client)
        {
            _ao3Client = client;
            return this;
        }

        public IChapterTableItemBuilder SetChapterModel(IChapterModel chapterModel)
        {
            _chapterModel = chapterModel;
            return this;
        }

        public IChapterTableItemBuilder SetChapterTitle(string title)
        {
            _chapterTitle = title;
            return this;
        }

        public IChapterTableItemBuilder SetDatabaseId(int id)
        {
            _databaseId = id;
            return this;
        }

        public IChapterTableItemBuilder SetPublishingDate(DateTime publishingDate)
        {
            _publishingDate = publishingDate;
            return this;
        }

        public IChapterTableItemBuilder SetStoryTitle(string storyTitle)
        {
            _storyTitle = storyTitle;
            return this;
        }

        public IChapterTableItemBuilder SetTableListener(ITableUpdateListener listener)
        {
            _tableListener = listener;
            return this;
        }
    }
}