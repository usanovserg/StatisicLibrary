
using MongoDB.Bson.Serialization.Attributes;
using StatisticLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticLibrary
{
    public class User
    {
        public User()
        {

        }

        #region Properties ===========================================================

        /// <summary>
        /// EMail юзера
        /// </summary>
        [BsonId]
        public string EMail { get; set; } = string.Empty;

        /// <summary>
        /// Список машин юзера, на которых он запускает наше ПО
        /// </summary>
        public List<Computer> Computers { get; set; } = new List<Computer>();


        #endregion Properties

        #region Public Fields ========================================================



        #endregion Public Methods

        #region private Fields =======================================================



        #endregion private Fields

        #region Commands =============================================================


        #endregion Commands

        #region Public Methods =======================================================


        #endregion Public Methods

        #region private Methods ======================================================



        #endregion private Methods
    }
}
