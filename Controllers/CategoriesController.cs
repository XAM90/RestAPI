﻿using Microsoft.AspNetCore.Mvc;
using RestAPITask.API.Services;
using RestAPITask.Models;
using System;


namespace RestAPITask.Controllers
{
    [ApiController]
    [Route("categories")]
    public class CategoriesController : ControllerBase
    {
        private readonly IProductLibraryRepository _productLibraryRepository;


        public CategoriesController(IProductLibraryRepository productLibraryRepository)
        {
            _productLibraryRepository = productLibraryRepository ??
                throw new ArgumentNullException(nameof(productLibraryRepository));
        }
        [HttpGet]
        public IActionResult GetCategories([FromQuery] CategoriesParameters categoryparameter)
        {
            var categoriessrepo = _productLibraryRepository.GetCategories(categoryparameter);
            return Ok(categoriessrepo);
        }
        
        [HttpGet("{categoryId}")]
        public IActionResult GetCategory(Guid categoryId, [FromQuery] CategoriesParameters categoryparameter)
        {
            var categoryrepo = _productLibraryRepository.GetCategory(categoryId, categoryparameter);

            if (categoryrepo == null)
            {
                return NotFound();
            }

            return Ok(categoryrepo);
        }

    }
}
