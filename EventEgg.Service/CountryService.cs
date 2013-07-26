using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AutoMapper;
using EventEgg.Data.Repositories;
using EventEgg.Domain.Event;
using EventEgg.Service.Infrastructure;
using EventEgg.Service.Interfaces;
using EventEgg.Service.Models;

namespace EventEgg.Service
{
    public class CountryService : IServiceBase<CountryViewModel>
    {
        private CountryRepository Repository { get; set; }

        public CountryService()
        {
            Repository = new CountryRepository();
        }

        #region Implementation of IServiceBase<Country>

        public CountryViewModel GetSingle(Expression<Func<CountryViewModel, bool>> whereCondition)
        {
            Mapper.CreateMap<Country, CountryViewModel>();
            var mapperExpression = Mapper.CreateMapExpression<Country, CountryViewModel>();
            var mappedSelector = whereCondition.Compose(mapperExpression);
            var people = Repository.SingleBy(mappedSelector);
            return Mapper.Map(people, new CountryViewModel());
        }

        public void Add(CountryViewModel entity)
        {

            Mapper.CreateMap<CountryViewModel, Country>();
            var coont = new Country();
            var mapping = Mapper.Map(entity, coont);

            Repository.Insert(mapping);
        }

        public void Delete(CountryViewModel entity)
        {
            Mapper.CreateMap<Country, CountryViewModel>();
            var mapping = Mapper.Map<CountryViewModel, Country>(entity);
            Repository.Delete(mapping);
        }

        public void Update(CountryViewModel entity)
        {
            Mapper.CreateMap<Country, CountryViewModel>();
            var mapping = Mapper.Map<CountryViewModel, Country>(entity);
            Repository.Update(mapping);
        }

        public IList<CountryViewModel> List()
        {
            Mapper.CreateMap<City, CityViewModel>();
            Mapper.CreateMap<Country, CountryViewModel>();
            var countryList = Repository.Query().ToList();
            var countryViewModelList = Mapper.Map(countryList, new List<CountryViewModel>());
            return countryViewModelList.ToList();
        }

        public IList<CountryViewModel> ListBy(Expression<Func<CountryViewModel, bool>> whereCondition)
        {
            Mapper.CreateMap<City, CityViewModel>();
            Mapper.CreateMap<Country, CountryViewModel>();
            var countryList = Repository.Query();
            var countryViewModelList = Mapper.Map(countryList, new List<CountryViewModel>());
            IQueryable<CountryViewModel> wsRet = countryViewModelList.AsQueryable().Where(whereCondition);
            return wsRet.ToList();
        }


        #endregion
    }
}
