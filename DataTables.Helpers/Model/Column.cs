namespace DataTables.Helpers.Model
{
    /// <summary>
    /// Defining column in the table.
    /// </summary>
    public class Column
    {
        /// <summary>
        /// Column's data source, as defined by columns.data.
        /// </summary>
        public string Data { get; set; }
        /// <summary>
        /// Column's name, as defined by columns.name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Flag to indicate if this column is searchable (true) or not (false). This is controlled by columns.searchable.
        /// </summary>
        public bool Searchable { get; set; }
        /// <summary>
        /// Flag to indicate if this column is orderable (true) or not (false). This is controlled by columns.orderable.
        /// </summary>
        public bool Orderable { get; set; }
        /// <summary>
        /// To be applied to column which have searchable as true.
        /// </summary>
        public Search Search { get; set; }
    }
}
