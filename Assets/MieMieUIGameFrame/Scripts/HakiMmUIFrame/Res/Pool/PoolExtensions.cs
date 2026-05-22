namespace MieMieFrameWork
{
    using MieMieFrameWork.Pool;
    using UnityEngine;

    /// <summary>
    /// 对象池相关的扩展方法
    /// </summary>
    public static class PoolExtensions
    {
        /// <summary>
        /// 将该GameObject放入对象池
        /// </summary>
        /// <param name="obj">目标GameObject</param>
        public static void PushGameObjectToPool(this GameObject obj)
        {
            PoolManager.Instance.PushGameObj(obj);
        }
        /// <summary>
        /// 将该Component身上的GameObject放入对象池
        /// </summary>
        /// <param name="component">目标Component</param>
        public static void PushGameObjectToPool(this Component component)
        {
            PoolManager.Instance.PushGameObj(component.gameObject);
        }

        /// <summary>
        /// 将该Object放入对象池
        /// </summary>
        /// <param name="obj">目标对象</param>
        public static void PushObjectToPool(this object obj)
        {
            PoolManager.Instance.PushObject(obj);
        }

    }
}
