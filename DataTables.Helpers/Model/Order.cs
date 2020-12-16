namespace DataTables.Helpers.Model
{
    /// <summary>
    /// Column to which ordering should be applied.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// This is an index reference to the columns array of information that is also submitted to the server.
        /// </summary>
        public int Column { get; set; }
        /// <summary>
        /// Ordering direction for this column. It will be asc or desc to indicate ascending ordering or descending ordering, respectively.
        /// </summary>
        public string Dir { get; set; }
    }
}
