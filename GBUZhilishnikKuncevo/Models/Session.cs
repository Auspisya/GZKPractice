//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GBUZhilishnikKuncevo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Session
    {
        public int id { get; set; }
        public int userId { get; set; }
        public System.DateTime sessionStart { get; set; }
        public int authAttempts { get; set; }
    
        public virtual User User { get; set; }
    }
}
