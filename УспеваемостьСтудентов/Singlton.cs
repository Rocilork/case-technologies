using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УспеваемостьСтудентов
{
    class Singlton
    {
        //приватное статичное поле
        private static БД_УспеваемостьEntities _context;
        //метод получения экземпляра контекста
        public static БД_УспеваемостьEntities GetContext()
        {
            if (_context == null)
                _context = new БД_УспеваемостьEntities();
            return _context;

        }
    }
}
