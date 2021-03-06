﻿using System;

namespace Model
{
    public class OrderHeader
    {
        /// <summary>
        /// The Date and Time when the OrderHeader was created
        /// </summary>
        public DateTime DateTime { get; set; }
        /// <summary>
        /// The Id of the OrderHeader
        /// In other words, the unique identifier of the order header
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The state of the OrderHeader. Can either be 1,2,3,4
        /// 1 = New
        /// 2 = Pending
        /// 3 = Rejected
        /// 4 = Complete
        /// </summary>
        public int State { get; set; }
        /// <summary>
        /// Constructor for the OrderHeader class
        /// </summary>
        /// <param name="dateTime">The Date and Time when the OrderHeader was created</param>
        /// <param name="id"></param>
        /// <param name="state">The state of the OrderHeader. Can either be 1,2,3,4</param>
        public OrderHeader(DateTime dateTime, int id, int state)
        {
            this.DateTime = dateTime;
            this.Id = id;
            this.State = state;
        }
    }
}
