﻿namespace WebApp.Models.ViewModels
{
    public class TopSellingItemViewModel
    {
        public string Id { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public string Title { get; set; } = null!;
        public decimal Price { get; set; }
    }
}
