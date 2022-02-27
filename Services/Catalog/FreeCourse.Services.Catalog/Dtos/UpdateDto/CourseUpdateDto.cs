﻿namespace FreeCourse.Services.Catalog.Dtos.UpdateDto
{
    internal class CourseUpdateDto
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int Picture { get; set; }

        public string UserId { get; set; }

        public FeatureDto Feature { get; set; }

        public string CategoryId { get; set; }
    }
}
