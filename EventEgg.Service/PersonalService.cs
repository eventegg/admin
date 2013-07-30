using AutoMapper;
using EventEgg.Data.Repositories;
using EventEgg.Domain.Personal;
using EventEgg.Service.Interfaces;
using EventEgg.Service.Models;
using System;
using System.Collections.Generic;
using EventEgg.Service.Infrastructure;

namespace EventEgg.Service
{
    public class PersonalService : IServiceBase<PersonalViewModel>, IDisposable
    {

        private PersonalRepository PersonalRepository { get; set; }

        public PersonalService()
        {
            PersonalRepository = new PersonalRepository();
        }

        public bool IsAuthenticate(string email, string password)
        {
            return PersonalRepository.IsAuthenticate(email, password);
        }

        public string GetRole(string email)
        {
            return PersonalRepository.GetRole(email);
        }

        public PersonalViewModel GetSingle(System.Linq.Expressions.Expression<Func<PersonalViewModel, bool>> whereCondition)
        {
            Mapper.CreateMap<PersonalDetail, PersonalViewModel>();
            var mapperExpression = Mapper.CreateMapExpression<PersonalDetail, PersonalViewModel>();
            var mappedSelector = whereCondition.Compose(mapperExpression);
            var people = PersonalRepository.SingleBy(mappedSelector);
            return Mapper.Map(people, new PersonalViewModel());
        }

        public void Add(PersonalViewModel entity)
        {
            Mapper.CreateMap<PersonalDetail, PersonalViewModel>();
            var personalDetail = new PersonalDetail();
            var mappedPersonal = Mapper.Map(entity, personalDetail);
            PersonalRepository.Insert(mappedPersonal);
        }

        public void Delete(PersonalViewModel entity)
        {
            throw new NotImplementedException();
        }

        public void Update(PersonalViewModel entity)
        {
            throw new NotImplementedException();
        }

        public IList<PersonalViewModel> ListBy(System.Linq.Expressions.Expression<Func<PersonalViewModel, bool>> whereCondition)
        {
            throw new NotImplementedException();
        }

        public IList<PersonalViewModel> List()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            PersonalRepository.Dispose();
        }

    }
}
