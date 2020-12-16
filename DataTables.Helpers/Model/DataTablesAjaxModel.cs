using System.Collections.Generic;

namespace DataTables.Helpers.Model
{
    /// <summary>
    /// When making a request to the server using server-side processing, DataTables will send the following data in order to let the server know what data is required.
    /// </summary>
    public class DataTableAjaxModel
    {
        /// <summary>
        /// Draw counter. This is used by DataTables to ensure that the Ajax returns from server-side processing requests are drawn in sequence by DataTables (Ajax requests are asynchronous and thus can return out of sequence). This is used as part of the draw return parameter (see below).
        /// </summary>
        public int Draw { get; set; }
        /// <summary>
        /// Paging first record indicator. This is the start point in the current data set (0 index based - i.e. 0 is the first record).
        /// </summary>
        public int Start { get; set; }
        /// <summary>
        /// Number of records that the table can display in the current draw. It is expected that the number of records returned will be equal to this number, unless the server has fewer records to return. Note that this can be -1 to indicate that all records should be returned (although that negates any benefits of server-side processing!)
        /// </summary>
        public int Length { get; set; }
        /// <summary>
        /// An array defining all columns in the table.
        /// </summary>
        public List<Column> Columns { get; set; }
        /// <summary>
        /// To be applied to all columns which have searchable as true.
        /// </summary>
        public Search Search { get; set; }
        /// <summary>
        ///  Is an array defining how many columns are being ordered upon - i.e. if the array length is 1, then a single column sort is being performed, otherwise a multi-column sort is being performed.
        /// </summary>
        public List<Order> Order { get; set; }
    }
}
