using QuanLyKhachSan.DAO;
using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmFoodList : Form
    {
        public frmFoodList()
        {
            InitializeComponent();
        }
        void LoadFoodList()
        {
            List<FoodList> lf = FoodListDAO.Instance.Load_ItemList();
            foreach (FoodList item in lf)
            {
                Item_Food ifs = new Item_Food();
                Item_ListFood ilf = new Item_ListFood();
                ifs.Margin = new Padding(3, 3, 3, 3);
                ilf.Margin = new Padding(2, 2, 2, 2);
                ifs.Size = new Size(132, 140);
                ifs.NameFood = item.TenTP;
                ifs.DonGia = item.GiaThanh.ToString();
                ifs.SoLuong = item.SoLuong.ToString();
                ifs.Hinhanh = item.HinhAnh;
                ilf.NameFood = item.TenTP;
                ilf.DonGia = item.GiaThanh.ToString();
                ilf.TongTien = item.GiaThanh.ToString();
                ilf.SoLuong = flpListOrder.Controls.Count;
                ifs.pt_Image.Click += (sender, e) =>
                {
                    if (Int32.Parse(ifs.SoLuong) > 0)
                    {
                        if (ifs.NameFood == ilf.NameFood)
                        {
                            ifs.check_valid.Visible = true;
                            ilf.NameFood = item.TenTP;
                            ilf.DonGia = item.GiaThanh.ToString();
                            ilf.Visible = true;
                            ilf.SoLuong = 1;
                            lbTotal.Text = (Int32.Parse(lbSubTotal.Text) + Int32.Parse(ilf.TongTien)).ToString();
                            lbSubTotal.Text = (Int32.Parse(lbSubTotal.Text) + Int32.Parse(ilf.TongTien)).ToString();
                            flpListOrder.Controls.Add(ilf);
                            ((Control)ifs.pt_Image).Enabled = false;
                            ilf.ptDelete.Click += (o, er) =>
                            {
                                ilf.TongTien = ilf.TongTien;
                                ilf.SoLuong = 0;
                            };
                        }
                        else
                        {
                            ifs.check_valid.Visible = false;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Thật xin lỗi! Tạm thời đã hết sản phẩm!");
                    }
                };
                ilf.ptDelete.Click += (o, er) =>
                {
                    ((Control)ifs.pt_Image).Enabled = true;
                    ifs.check_valid.Visible = false;
                    ilf.lbCount.Text = "1";
                    flpListOrder.Controls.Remove(ilf);
                    if (ilf.SoLuong == 1)
                    {
                        lbTotal.Text = (Int32.Parse(lbSubTotal.Text) - Int32.Parse(ilf.TongTien)).ToString();
                        lbSubTotal.Text = (Int32.Parse(lbSubTotal.Text) - Int32.Parse(ilf.TongTien)).ToString();
                    }
                    else
                    {
                        lbTotal.Text = (Int32.Parse(lbSubTotal.Text) - (Int32.Parse(ilf.TongTien) * ilf.SoLuong)).ToString();
                        lbSubTotal.Text = (Int32.Parse(lbSubTotal.Text) - (Int32.Parse(ilf.TongTien) * ilf.SoLuong)).ToString();

                    }
                };
                ((Control)ilf.btnPlus).Click += (o, er) =>
                {
                    lbTotal.Text = (Int32.Parse(lbSubTotal.Text) + Int32.Parse(ilf.TongTien)).ToString();
                    lbSubTotal.Text = (Int32.Parse(lbSubTotal.Text) + Int32.Parse(ilf.TongTien)).ToString();
                    ilf.SoLuong += 1;
                };
                ((Control)ilf.btnMinus).Click += (o, er) =>
                {
                    lbTotal.Text = (Int32.Parse(lbSubTotal.Text) - Int32.Parse(ilf.TongTien)).ToString();
                    lbSubTotal.Text = (Int32.Parse(lbSubTotal.Text) - Int32.Parse(ilf.TongTien)).ToString();
                    ilf.SoLuong -= 1;
                };
                flpFoodList.Controls.Add(ifs);

                btnFoods.Click += (oe, er) =>
                {
                    if (item.Loai == "Drinks" || item.Loai == "Snack" || item.Loai == "Milk Tea")
                    {
                        ifs.Visible = false;
                    }
                    if (item.Loai == "Foods")
                    {
                        ifs.Visible = true;
                    }
                };

                btnDrinks.Click += (oe, er) =>
                {
                    if (item.Loai == "Foods" || item.Loai == "Snack" || item.Loai == "Milk Tea")
                    {
                        ifs.Visible = false;
                    }
                    if (item.Loai == "Drinks")
                    {
                        ifs.Visible = true;
                    }
                };

                btnSnack.Click += (oe, er) =>
                {
                    if (item.Loai == "Foods" || item.Loai == "Drinks" || item.Loai == "Milk Tea")
                    {
                        ifs.Visible = false;
                    }
                    if (item.Loai == "Snack")
                    {
                        ifs.Visible = true;
                    }
                };

                btnMilkTea.Click += (oe, er) =>
                {
                    if (item.Loai == "Foods" || item.Loai == "Drinks" || item.Loai == "Snack")
                    {
                        ifs.Visible = false;
                    }
                    if (item.Loai == "Milk Tea")
                    {
                        ifs.Visible = true;
                    }
                };

                btnConfirm.Click += (o, er) =>
                {
                    if (ilf.Enabled == false)
                    {
                        FoodListDAO.Instance.Insert_BillFoods(lbCustomerCode.Text, item.ID, item.TenTP, ilf.SoLuong, item.GiaThanh, (ilf.SoLuong * item.GiaThanh));
                        FoodListDAO.Instance.Update_SoLuong((item.SoLuong - ilf.SoLuong), item.ID);
                        flpListOrder.Controls.Remove(ilf);
                    }
                    else
                    {
                        return;
                    }
                };
            }

            btnConfirm.Click += (o, er) =>
            {
                if(flpListOrder.Controls.Count == 0)
                {
                    MessageBoxSuccess ms = new MessageBoxSuccess();
                    ms.ShowDialog();
                    btnConfirm.Visible = false;
                    btnCancelAll.Visible = false;
                    btnBillPlease.Visible = true;
                    flpFoodList.Controls.Clear();
                    LoadFoodList();
                }
            };

        }
        private void btnBillPlease_Click(object sender, EventArgs e)
        {
            if (lbSubTotal.Text == "0")
            {
                frmMessageNotification ms = new frmMessageNotification();
                frmMessageNotification.text = "Không có gì để thanh toán!";
                ms.Show();
                ms.btnConfirm.Click += (o, er) =>
                {
                    ms.Close();
                };
                ms.ptClose.Click += (o, er) =>
                {
                    ms.Close();
                };
            }
            else
            {
                btnConfirm.Visible = true;
                btnCancelAll.Visible = true;
                btnBillPlease.Visible = false;
                flpListOrder.Enabled = false;
                cbDiscount.Enabled = false;
            }
        }

        private void cbDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDiscount.Checked == false)
            {
                lbTotal.Text = lbSubTotal.Text;
            }
            else
            {
                lbTotal.Text = (Int32.Parse(lbSubTotal.Text) - (Int32.Parse(lbSubTotal.Text) * 20 / 100)).ToString();
            }
        }

        private void btnCancelAll_Click(object sender, EventArgs e)
        {
            btnConfirm.Visible = false;
            btnCancelAll.Visible = false;
            btnBillPlease.Visible = true;
            flpListOrder.Enabled = true;
            cbDiscount.Enabled = true;
            cbDiscount.Checked = false;
            lbSubTotal.Text = "0";
            lbTotal.Text = "0";
            flpListOrder.Controls.Clear();
            flpFoodList.Controls.Clear();
            LoadFoodList();
        }


        private void frmFoodList_Load(object sender, EventArgs e)
        {
            LoadFoodList();
            cbRoomCode.DataSource = FoodListDAO.Instance.Load_IDKH();
            cbRoomCode.DisplayMember = "MaPhong";
            cbRoomCode.ValueMember = "MaPhong";
        }

        private void cbRoomCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRoomCode.Text == "")
            {
                lbCustomerCode.Text = "";
            }
            else
            {
                lbCustomerCode.Text = FoodListDAO.Instance.Load_WithIDRoom(cbRoomCode.Text);
            }

        }

        private void lbSubTotal_TextChanged(object sender, EventArgs e)
        {
            lbSubTotal.Text = String.Format("{0:0,0}", lbSubTotal.Text);

        }

        private void lbTotal_TextChanged(object sender, EventArgs e)
        {
            lbTotal.Text = String.Format("{0:0,0}", lbTotal.Text);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            if(FoodListDAO.Instance.Load_Bill(lbCustomerCode.Text).Rows.Count > 0)
            {
                frmHistoryFoods frs = new frmHistoryFoods(lbCustomerCode.Text);
                frs.ShowDialog();
            }
            else
            {
                frmMessageNotification ms = new frmMessageNotification();
                frmMessageNotification.text = "Customers have not ordered!Please order and watch later!";
                ms.Show();
                ms.btnConfirm.Click += (o, er) =>
                {
                    ms.Close();
                };
            }
        }
    }
}
