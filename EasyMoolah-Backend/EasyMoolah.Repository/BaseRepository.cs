using AutoMapper;
using EasyMoolah.Model;
using EasyMoolah.Model.Exceptions;
using System;

namespace EasyMoolah.Repository
{
    public class BaseRepository
    {
        protected readonly EasyMoolahContext DbContext;
        protected readonly IMapper Mapper;

        protected BaseRepository(EasyMoolahContext dbContext, IMapper mapper)
        {
            DbContext = dbContext;
            Mapper = mapper;
        }

        protected T Map<T>(object item)
        {
            return Mapper.Map<T>(item);
        }

        protected void SetAddItemDetails<T>(T item) where T: BaseModel
        {
            item.IsActive = true;
            item.CreateDate = DateTime.UtcNow;
            item.ChangeDate = DateTime.UtcNow;
        }

        protected void SetRemoveItemDetails<T>(T item) where T : BaseModel
        {
            item.IsActive = false;
            item.CreateDate = DateTime.UtcNow;
            item.ChangeDate = DateTime.UtcNow;
        }

        protected void SetEditItemDetails<T>(T item) where T : BaseModel
        {
            item.IsActive = true;
            item.CreateDate = DateTime.UtcNow;
            item.ChangeDate = DateTime.UtcNow;
        }
    }
}
