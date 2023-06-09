﻿using _2.Data.ModelsClass;

namespace _4.Client.IServices
{
    public interface IAllServices
    {
        Task<T> GetById<T>(string url,Guid id);
        Task<T> Add<T>(string url,T model);
        Task<bool> Remove<T>(string urlGetById, string urlRemove, Guid id);
        Task<T> Update<T>(string url, T model, Guid id);
        Task<List<T>> GetAll<T>(string url);
    }
}
