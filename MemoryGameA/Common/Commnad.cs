using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MemoryGameA
{
    class Command
    {
        // ↓Commandを使ったボタン処理に必要な定義
        public class RelayCommand<T> : ICommand
        {
            // Command実行時に実行するアクション、引数あり
            private Action<T> _action;

            /// <name>
            /// RelayCommand
            /// </name>
            /// <summary>
            /// コンストラクタ
            /// </summary>
            /// <param name="action">実行するアクション</param>
            public RelayCommand(Action<T> action)
            {
                _action = action;
            }

            #region ICommandインターフェースの必須実装

            public event EventHandler CanExecuteChanged;

            /// <name>
            /// RaiseCanExecuteChanged
            /// </name>
            /// <summary>
            /// ビルド時の CanExecuteChangedのワーニング抑止のため下記のように修正　方法２
            /// </summary>
            public void RaiseCanExecuteChanged()
            {
                CanExecuteChanged?.Invoke(this, EventArgs.Empty);
            }

            /// <name>
            /// CanExecute
            /// </name>
            /// <summary>
            /// 実行可能かどうか取得する
            /// </summary>
            /// <param name="parameter"></param>
            /// <returns>結果:アクションが存在し、実行可能</returns>
            public bool CanExecute(object parameter)
            {//とりあえずActionがあれば実行可能
                return _action != null;
            }

            /// <name>
            /// Execute
            /// </name>
            /// <summary>
            /// 実行
            /// </summary>
            /// <param name="parameter">コマンドパラメーター</param>
            public void Execute(object parameter)
            {
                //Console.WriteLine("Execute Type2 called param={0}", parameter);
                _action?.Invoke((T)parameter);
            }

            #endregion

        }
    }
}
