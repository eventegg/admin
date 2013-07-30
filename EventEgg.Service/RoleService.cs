using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AutoMapper;
using EventEgg.Data.Repositories;
using EventEgg.Domain.Personal;
using EventEgg.Service.Interfaces;
using EventEgg.Service.Models;

namespace EventEgg.Service
{
    public class RoleService : IServiceBase<RoleViewModel>
    {
        #region Implementation of IServiceBase<RoleViewModel>

        private RoleRepository _repository;

        public RoleViewModel GetSingle(Expression<Func<RoleViewModel, bool>> whereCondition)
        {
            throw new NotImplementedException();
        }

        public void Add(RoleViewModel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(RoleViewModel entity)
        {
            throw new NotImplementedException();
        }

        public void Update(RoleViewModel entity)
        {
            throw new NotImplementedException();
        }

        public IList<RoleViewModel> ListBy(Expression<Func<RoleViewModel, bool>> whereCondition)
        {
            throw new NotImplementedException();
        }

        public IList<RoleViewModel> List()
        {
            Mapper.CreateMap<Role, RoleViewModel>();
            var roles = _repository.Query().ToList();
            return Mapper.Map(roles, new List<RoleViewModel>());
        }

        #endregion
    }
}
