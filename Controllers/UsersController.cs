using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bogus_MVC_.Data;
using Bogus_MVC_.Models;
using Bogus;
using NuGet.Protocol;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Data.OleDb;
using System.Text;
using System.Diagnostics;
using Microsoft.Data.SqlClient;
using ToDataTable;

namespace Bogus_MVC_.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

      
    
        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Email,PhoneNumber,Address")] User user)
        {
            //var i = 1;
            var PostTrans = new Faker<PostTran>();
            

            //Type types = typeof(PostTran);

            var faker = new Faker("en");

            PostTran[] posts = new PostTran[2000000]; // 2,illion


            string[] SpecialIDS = { "PostTranId", "PrevPostTranId", "NextPostTranId", "PrevTranApproved" };
            long[] SpecialIDCounter = { 0, -1, 1, -1 };


            long i = 0;

            var eo = new PostTran();

            // OleDbDataReader reader = command.ExecuteReader();
            string Path = @"C:\\Users\\AbdulgaffarAbdulmali\\Documents\Buffer.txt";
            //StreamWriter writer = new StreamWriter($path);

           // using (StreamWriter streamwriter = new StreamWriter(Path, true, Encoding.UTF8, 65536))
            //{
                while (i < posts.Length)
                {
                 eo = new PostTran();

                eo.PostTranId = (long) SpecialIDCounter[0]++;
                    eo.PrevPostTranId = (long) faker.Random.Long();
                    eo.NextPostTranId = (long) faker.Random.Long();
                    eo.PrevTranApproved = faker.Random.Decimal();
                    eo.AbortRspCode = "ifndifd";


                    posts[i] = eo;

                   // streamwriter.WriteLine("Some line of text");

                    i++;

                }


                using(var copy = new SqlBulkCopy("Server=localhost;Database=master;Trusted_Connection=True;"))
                {

                    copy.DestinationTableName = "dbo.post_tran";
                   
                    copy.BulkCopyTimeout= 10000;
                    Stopwatch regularSW = new Stopwatch();

                    regularSW.Start();
                    copy.ColumnMappings.Add(nameof(PostTran.PostTranId), "post_tran_id");
                    copy.ColumnMappings.Add(nameof(PostTran.PrevPostTranId), "prev_post_tran_id");
                    copy.ColumnMappings.Add(nameof(PostTran.NextPostTranId), "next_post_tran_id");
                    copy.ColumnMappings.Add(nameof(PostTran.PrevTranApproved), "prev_tran_approved");

                    // Array.Todat
                    var dt = posts.ToDataTable<PostTran>();   
                    copy.WriteToServer(dt);

                    regularSW.Stop();

                    Console.WriteLine("Measured time: " + regularSW.Elapsed);

                }



            //}


            return Json(new int[] { 1,2}); //RedirectToAction(nameof(Index));
        }

    }
}
