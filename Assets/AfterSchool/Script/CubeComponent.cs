using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeComponent : MonoBehaviour
{
    public GameManager gameManager;

    public new Transform transform;
    public Animator animator;
    
    [Header("Commons")]
    [Tooltip ("오브젝트에 사용되는 모든 랜더러 컴포넌트")]
    public MeshRenderer[] renderers;
    [Tooltip ("모자 오브젝트")]
    public GameObject hat;
    [Tooltip ("발사 지점")]
    public Transform firePoint;
    

    [System.Serializable]
    public struct Stats
    {
        public int health;
        public float healthRegen;

        [Space(10f)]
        public int attackPoint;
        public float attackSpeed;
        public float attackDelay;

        [Space(10f)]
        public float moveSpeed;
        public float rotSpeed;

        [Space(10f)]
        public float JumpAmount;
        public bool isJumping;
    }
    [Header("Player Stats")]
    public Stats stats;

    [Header("Infoamtion")]
    public new string name;
    public string desc;
    [Multiline (3)]
    public string desc2;
    [TextArea (3, 5)]
    public string desc3;

    [Header("Resize Data")]
    [Range (0.5f, 1.5f)]
    public float resizeAmoint;
    public Vector3 minSize;
    public Vector3 maxSize;

}
