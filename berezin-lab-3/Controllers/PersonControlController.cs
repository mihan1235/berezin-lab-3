using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Libs;
using static berezin_lab_3.WebApiApplication;

namespace berezin_lab_3.Controllers
{
    public class PersonControlController : ApiController
    {
        public static DataBase db { get; } = new DataBase();
        // GET api/<controller>
        [Route("api/PersonControls")]
        public IEnumerable<PersonControlData> Get()
        {
             return db.PersonControlDatas.ToArray();
        }

        // GET api/<controller>/5
        [Route("api/PersonControls/{id}")]
        public PersonControlData Get(int id)
        {
            PersonControlData obj = db.PersonControlDatas.FirstOrDefault(p => p.Id == id);
            return obj;
        }

        // POST api/<controller>
        [Route("api/PersonControls")]
        public int Post([FromBody]PersonControlData obj)
        {
            db.PersonControlDatas.Add(obj);
            db.SaveChanges();
            return obj.Id;
        }

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // DELETE api/<controller>/5
        [Route("api/PersonControls/{id}")]
        public void Delete(int id)
        {
            PersonControlData obj = db.PersonControlDatas.FirstOrDefault(p => p.Id == id);
            db.PersonControlDatas.Attach(obj);
            if (obj.PersonsList != null)
                foreach (var child in obj.PersonsList.ToList())
                {
                    db.Entry(child.faceAttributes).State = EntityState.Deleted;
                    db.Entry(child.faceRectangle).State = EntityState.Deleted;
                    db.Entry(child).State = EntityState.Deleted;
                }
            if (obj.ErrorResult != null)
                db.Entry(obj.ErrorResult).State = EntityState.Deleted;
            db.PersonControlDatas.Remove(obj);
            db.SaveChanges();
        }
    }
}