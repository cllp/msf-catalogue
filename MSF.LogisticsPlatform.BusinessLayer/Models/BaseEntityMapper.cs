using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.LogisticsPlatform.BusinessLayer.ViewModels
{
    /// <summary>
    /// Allows to map a ViewModel to/from a Domain Entity.
    /// </summary>
    /// <typeparam name="TViewModel">Type of the view model</typeparam>
    /// <typeparam name="TEntity">Type of the entity</typeparam>
    public abstract class BaseEntityMapper<TViewModel, TEntity>
        where TEntity : class
        where TViewModel : class
    {
        /// <summary>
        /// Initializes the <see cref="BaseEntityMapper{TViewModel,TEntity}"/> class.
        /// </summary>
        static BaseEntityMapper()
        {
            // Define the default mapping, 
            // custom configuration can be also defined and will be merged with this one
            Mapper.Initialize(cfg => cfg.CreateMap<TViewModel, TEntity>());
            Mapper.Initialize(cfg => cfg.CreateMap<TEntity, TViewModel>());
        }

        /// <summary>
        /// Maps the specified view model to a entity object.
        /// </summary>
        public TEntity MapToEntity()
        {
            // Map the derived class to the represented view model
            return Mapper.Map<TEntity>(CastToDerivedClass(this));
        }

        /// <summary>
        /// Maps a entity to a view model instance.
        /// </summary>
        public static TViewModel MapFromEntity(TEntity model)
        {
            return Mapper.Map<TViewModel>(model);
        }

        #region Private

        /// <summary>
        /// Gets the derived class.
        /// </summary>
        private static TViewModel CastToDerivedClass(BaseEntityMapper<TViewModel, TEntity> baseInstance)
        {
            return Mapper.Map<TViewModel>(baseInstance);
        }

        #endregion
    }

}
