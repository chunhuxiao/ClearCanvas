#region License

// Copyright (c) 2013, ClearCanvas Inc.
// All rights reserved.
// http://www.clearcanvas.ca
//
// This file is part of the ClearCanvas RIS/PACS open source project.
//
// The ClearCanvas RIS/PACS open source project is free software: you can
// redistribute it and/or modify it under the terms of the GNU General Public
// License as published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// The ClearCanvas RIS/PACS open source project is distributed in the hope that it
// will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General
// Public License for more details.
//
// You should have received a copy of the GNU General Public License along with
// the ClearCanvas RIS/PACS open source project.  If not, see
// <http://www.gnu.org/licenses/>.

#endregion

// This file is auto-generated by the ClearCanvas.Model.SqlServer.CodeGenerator project.

namespace ClearCanvas.ImageServer.Model
{
    using System;
    using System.Xml;
    using ClearCanvas.Enterprise.Core;
    using ClearCanvas.ImageServer.Enterprise;
    using ClearCanvas.ImageServer.Model.EntityBrokers;

    [Serializable]
    public partial class NotificationQueue: ServerEntity
    {
        #region Constructors
        public NotificationQueue():base("NotificationQueue")
        {}
        public NotificationQueue(
             ServerEntityKey _externalRequestQueueKey_
            ,String _restNotificationUrl_
            ,XmlDocument _notificationXml_
            ,DateTime _insertTime_
            ,DateTime _lastTryTime_
            ,Boolean _failed_
            ,Int32 _retryCount_
            ):base("NotificationQueue")
        {
            ExternalRequestQueueKey = _externalRequestQueueKey_;
            RestNotificationUrl = _restNotificationUrl_;
            NotificationXml = _notificationXml_;
            InsertTime = _insertTime_;
            LastTryTime = _lastTryTime_;
            Failed = _failed_;
            RetryCount = _retryCount_;
        }
        #endregion

        #region Public Properties
        [EntityFieldDatabaseMappingAttribute(TableName="NotificationQueue", ColumnName="ExternalRequestQueueGUID")]
        public ServerEntityKey ExternalRequestQueueKey
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="NotificationQueue", ColumnName="RestNotificationUrl")]
        public String RestNotificationUrl
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="NotificationQueue", ColumnName="NotificationXml")]
        public XmlDocument NotificationXml
        { get { return _NotificationXml; } set { _NotificationXml = value; } }
        [NonSerialized]
        private XmlDocument _NotificationXml;
        [EntityFieldDatabaseMappingAttribute(TableName="NotificationQueue", ColumnName="InsertTime")]
        public DateTime InsertTime
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="NotificationQueue", ColumnName="LastTryTime")]
        public DateTime LastTryTime
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="NotificationQueue", ColumnName="Failed")]
        public Boolean Failed
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="NotificationQueue", ColumnName="RetryCount")]
        public Int32 RetryCount
        { get; set; }
        #endregion

        #region Static Methods
        static public NotificationQueue Load(ServerEntityKey key)
        {
            using (var read = PersistentStoreRegistry.GetDefaultStore().OpenReadContext())
            {
                return Load(read, key);
            }
        }
        static public NotificationQueue Load(IPersistenceContext read, ServerEntityKey key)
        {
            var broker = read.GetBroker<INotificationQueueEntityBroker>();
            NotificationQueue theObject = broker.Load(key);
            return theObject;
        }
        static public NotificationQueue Insert(NotificationQueue entity)
        {
            using (var update = PersistentStoreRegistry.GetDefaultStore().OpenUpdateContext(UpdateContextSyncMode.Flush))
            {
                NotificationQueue newEntity = Insert(update, entity);
                update.Commit();
                return newEntity;
            }
        }
        static public NotificationQueue Insert(IUpdateContext update, NotificationQueue entity)
        {
            var broker = update.GetBroker<INotificationQueueEntityBroker>();
            var updateColumns = new NotificationQueueUpdateColumns();
            updateColumns.ExternalRequestQueueKey = entity.ExternalRequestQueueKey;
            updateColumns.RestNotificationUrl = entity.RestNotificationUrl;
            updateColumns.NotificationXml = entity.NotificationXml;
            updateColumns.InsertTime = entity.InsertTime;
            updateColumns.LastTryTime = entity.LastTryTime;
            updateColumns.Failed = entity.Failed;
            updateColumns.RetryCount = entity.RetryCount;
            NotificationQueue newEntity = broker.Insert(updateColumns);
            return newEntity;
        }
        #endregion
    }
}
