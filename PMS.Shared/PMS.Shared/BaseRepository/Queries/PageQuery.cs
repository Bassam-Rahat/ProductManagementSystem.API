﻿namespace PMS.Shared.BaseRepository.Queries
{
    public class PageQuery
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 20;
    }
}