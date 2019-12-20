using MTS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MTS.Core.DataAcces
{
   public interface IEntityRepository<T> where T:class ,IEntity,new()//Bu Generic tipini desteklemeli
    {

        //Get ve getlist için güzel bi yapı oluşturuldu
        //Expression u yaz veri tabanına o sorguyu yaz
        //Northwinde etkileyen bir kod blogu yok o yüzden burada tanımlandı 
        //Parametreyi geçerekte metodu tamamlayabilir
        T Get(Expression<Func<T,bool>> Filter = null  );

        //liste tipinde isteyebiliriz 
        List<T> GetList(Expression<Func<T, bool>> Filter = null);

        //Gelen nesneyi direk veri tabanına yazmak için
        void Add(T Entity);
        //Gelen nesneyi update etmek için
        void Update(T Entity);

        void Delete(T Entity);




    }
}
