﻿namespace MovieStreaming.Messages
{
    public sealed class IncrementPlayCountMessage
    {
        public string MovieTitle { get; private set; }

        public IncrementPlayCountMessage(string movieTitle)
        {
            MovieTitle = movieTitle;
        }
    }
}