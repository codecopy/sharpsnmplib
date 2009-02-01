/*
 * Created by SharpDevelop.
 * User: lextm
 * Date: 2008/5/21
 * Time: 19:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System.Collections.Generic;

namespace Lextm.SharpSnmpLib.Mib
{
    /// <summary>
    /// Description of NotificationGroupNode.
    /// </summary>
    internal sealed class NotificationGroup : IEntity
    {
        private readonly string _module;
        private string _parent;
        private readonly uint _value;
        private readonly string _name;

        public NotificationGroup(string module, IList<Symbol> header, Lexer lexer)
        {
            _module = module;
            _name = header[0].ToString();
            ConstructHelper.ParseOidValue(lexer, out _parent, out _value);
        }

        public string ModuleName
        {
            get { return _module; }
        }

        public string Parent
        {
            get { return _parent; }
            set { _parent = value; }
        }

        public uint Value
        {
            get { return _value; }
        }

        public string Name
        {
            get { return _name; }
        }
    }
}