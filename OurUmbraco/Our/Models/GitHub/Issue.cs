﻿using System;
using Newtonsoft.Json;

namespace OurUmbraco.Our.Models.GitHub
{
    public class Issue
    {
        [JsonProperty("html_url")]
        public string Link { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("labels")]
        public Label[] Labels { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("assignees")]
        public User[] Assignees { get; set; }

        [JsonProperty("comments")]
        public int CommentCount { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreateDateTime { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdateDateTime { get; set; }

        [JsonProperty("closed_at")]
        public DateTime? ClosedDateTime { get; set; }

        [JsonProperty("body")]
        public string Description { get; set; }

        [JsonProperty("_comments")]
        public Comments[] Comments { get; set; }

        // Custom properties

        public string RepositoryName { get; set; }

        public DateTime? FirstPrTeamOrHqComment { get; set; }

        // Note: leaving the other properties commented out in case we need them later

        //public string repository_url { get; set; }
        //public string labels_url { get; set; }
        //public string comments_url { get; set; }
        //public string events_url { get; set; }
        //public int id { get; set; }
        //public string node_id { get; set; }
        //public bool locked { get; set; }
        //public User assignee { get; set; }
        //public object milestone { get; set; }
        //public string author_association { get; set; }
    }
}
