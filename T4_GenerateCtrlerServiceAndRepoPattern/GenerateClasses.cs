

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GenerateControllerServiceRepo
{ 
   	//****GENERATED CONTROLLER, SERVICE AND REPOSITORY FOR PRODUCT****

	//[ApiController] 
	public class ProductController 
	//: ControllerBase
	{
		private readonly ProductService _productService;

		public ProductController(DbContext context)
		{
			_productService = new ProductService(context);
		}

		//[HttpGet]
		//[ProducesResponseType(200, Type = typeof(Product))]
		//public async Task<IActionResult> Get()
		//{
		//		var result = await _productService.GetAll();
        //		return Ok(result)
		//}
	}



	public class ProductService
	{ 
		//Add repository injection
		private readonly ProductRepository _productRepository;

		//Add ctor that will accept dbcontext
		public ProductService(DbContext context){

			_productRepository = new ProductRepository(context);

		}

		//Example method for retrieving all rows in the entity (uncomment when types available)
		//public Product GetAll() {
		//		return _productRepository.GetAll;
		//}

	} 

	public class ProductRepository
	{ 
		//Add repository injection
		private readonly DbContext _ctx;

		//Add ctor that will accept dbcontext
		public ProductRepository(DbContext ctx){

			_ctx = ctx;

		}
		
		//Example method for retrieving all rows in the entity (uncomment when types available)
		//public Product GetAll() {
		//		return _ctx.Product.Where(row => row != null).ToList()
		//}
	}





 
 	//****GENERATED CONTROLLER, SERVICE AND REPOSITORY FOR CATEGORY****

	//[ApiController] 
	public class CategoryController 
	//: ControllerBase
	{
		private readonly CategoryService _categoryService;

		public CategoryController(DbContext context)
		{
			_categoryService = new CategoryService(context);
		}

		//[HttpGet]
		//[ProducesResponseType(200, Type = typeof(Category))]
		//public async Task<IActionResult> Get()
		//{
		//		var result = await _categoryService.GetAll();
        //		return Ok(result)
		//}
	}



	public class CategoryService
	{ 
		//Add repository injection
		private readonly CategoryRepository _categoryRepository;

		//Add ctor that will accept dbcontext
		public CategoryService(DbContext context){

			_categoryRepository = new CategoryRepository(context);

		}

		//Example method for retrieving all rows in the entity (uncomment when types available)
		//public Category GetAll() {
		//		return _categoryRepository.GetAll;
		//}

	} 

	public class CategoryRepository
	{ 
		//Add repository injection
		private readonly DbContext _ctx;

		//Add ctor that will accept dbcontext
		public CategoryRepository(DbContext ctx){

			_ctx = ctx;

		}
		
		//Example method for retrieving all rows in the entity (uncomment when types available)
		//public Category GetAll() {
		//		return _ctx.Category.Where(row => row != null).ToList()
		//}
	}





 
 	//****GENERATED CONTROLLER, SERVICE AND REPOSITORY FOR COMPANY****

	//[ApiController] 
	public class CompanyController 
	//: ControllerBase
	{
		private readonly CompanyService _companyService;

		public CompanyController(DbContext context)
		{
			_companyService = new CompanyService(context);
		}

		//[HttpGet]
		//[ProducesResponseType(200, Type = typeof(Company))]
		//public async Task<IActionResult> Get()
		//{
		//		var result = await _companyService.GetAll();
        //		return Ok(result)
		//}
	}



	public class CompanyService
	{ 
		//Add repository injection
		private readonly CompanyRepository _companyRepository;

		//Add ctor that will accept dbcontext
		public CompanyService(DbContext context){

			_companyRepository = new CompanyRepository(context);

		}

		//Example method for retrieving all rows in the entity (uncomment when types available)
		//public Company GetAll() {
		//		return _companyRepository.GetAll;
		//}

	} 

	public class CompanyRepository
	{ 
		//Add repository injection
		private readonly DbContext _ctx;

		//Add ctor that will accept dbcontext
		public CompanyRepository(DbContext ctx){

			_ctx = ctx;

		}
		
		//Example method for retrieving all rows in the entity (uncomment when types available)
		//public Company GetAll() {
		//		return _ctx.Company.Where(row => row != null).ToList()
		//}
	}





 
 }





