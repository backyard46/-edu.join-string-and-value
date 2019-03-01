using System;
using System.Windows.Forms;

namespace JoinStringAndValue
{
    /// <summary>
    /// 文字と数字混在で結合した場合の挙動確認。
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class JoinStringAndValue : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JoinStringAndValue"/> class.
        /// </summary>
        public JoinStringAndValue()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 文字と数値の結合テスト。
        /// </summary>
        /// <remarks>
        /// ・C#は式の評価を左から順に行う。
        /// ・C#では、文字と数値が足し算されると、数値は文字に自動変換される。
        /// 　※ただし、これを活用したプログラムはあまり作らないほうが良い。
        /// 　　後からプログラムを見た人がこのルールを熟知していないと誤読する可能性があるので。
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGo_Click(object sender, EventArgs e)
        {
            // 文字(string)とintなどの数値を足し算すると、数値は文字に自動変換される

            // 式は左から解釈されるので、最初に「今は2000」という文字列が作られる。
            // 次に、「今は2000」という文字に「18」が文字として結合される。
            TextResult.Text = "今は" + 2000 + 18 + "年です";

            // 最初に「2000+18」という数値計算が行われる。
            // 次に、2018という数字と文字の足し算なので、数字が文字に自動変換される。
            TextResult2.Text = 2000 + 18 + "年です";

        }
    }
}
