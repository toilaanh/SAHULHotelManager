using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAHULHotelManager.DTO
{
    public class CPosition
    {
        #region "attribus"
        private int _id;
        private string _name;
        private int _departmentid;
        private CEmployee _chief;
        #endregion
        #region "property"
        public new string ToString
        {
            get
            {
                return this.ShowInFors();
            }
        }
        public int id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }
        public string name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }
        public int departmentid
        {
            get
            {
                return _departmentid;
            }

            set
            {
                _departmentid = value;
            }
        }
        public CEmployee Chief
        {
            get
            {
                return _chief;
            }

            set
            {
                _chief = value;
            }
        }
        #endregion
        #region "construction"
        //khoi tao khong tham so
        public CPosition()
        {
            this.id = 0;
            this.name = string.Empty;
            this.departmentid = 0;
            this.Chief = new CEmployee();
        }
        //khoi tao co tham so
        public CPosition(CPosition cposition)
        {
            this.id = cposition.id;
            this.name = cposition.name;
            this.departmentid = cposition.departmentid;
            this.Chief = cposition.Chief;
        }
        public CPosition(int id1, string name1, int department1)
        {
            this.id = id1;
            this.name = name1;
            this.departmentid = department1;
            this.Chief = null;
        }
        public CPosition(int id1, string name1, int department1, CEmployee chief)
        {
            this.id = id1;
            this.name = name1;
            this.departmentid = department1;
            this.Chief = chief;
        }
        #endregion
        #region "method"
        //show doi tuong
        public string ShowInfors()
        {
            return "\n\tID:" + id + "\n\tNAME: " + name + "\n\tDEPARTMENT ID:" + departmentid + "\n\tChief:" + Chief;
        }

        public List<CPosition> GenerateObjects()
        {
            List<CPosition> Position = new List<CPosition>();
            Position.Add(new CPosition(1, "Giám Đốc", 1));
            Position.Add(new CPosition(2, "Trợ Lý Giám Đốc", 2));
            Position.Add(new CPosition(3, "Thư Ký", 3));
            Position.Add(new CPosition(4, "kỹ Thuật", 4));
            Position.Add(new CPosition(5, "Đầu Bếp", 5));
            Position.Add(new CPosition(6, "Lễ Tân", 6));
            Position.Add(new CPosition(7, "Kế Toán", 7));
            Position.Add(new CPosition(8, "Chăm Sóc Khách Hàng", 8));
            Position.Add(new CPosition(9, "Tạp Vụ", 9));
            Position.Add(new CPosition(10, "Bảo Vệ", 10));
            return Position;
        }
        #endregion
    }
}