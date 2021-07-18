namespace Patterns.Impl.Behavior.State
{
    public abstract class State
    {
        protected Context _context;

        public void SetContext(Context context)
        {
            this._context = context;
        }

        public abstract void Action1();

        public abstract void Action2();
    }
}
