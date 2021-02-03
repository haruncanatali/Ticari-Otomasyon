using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretOtomasyonu.Entities.Abstract;

namespace TicariOtomasyon.DataAccess.Abstract
{
    public interface IEntityRepository<TEntity> where TEntity:class,IEntity,new()
    {
        DataTable List();
        TEntity Get(TEntity entity);
        TEntity Add(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity Delete(TEntity entity);
    }
}
