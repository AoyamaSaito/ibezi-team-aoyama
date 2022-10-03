using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Stage�̏��(���C�t�A�X�R�A)���Ǘ�����N���X
/// </summary>
public class StageState
{
    public int Life { get; private set; }

    public int Score { get; private set; }

    public StageState()
    {
        
    }

    /// <summary>
    /// Stage�̏���������
    /// </summary>
    /// <param name="life"></param>
    public void Init(int life)
    {
        Life = life;
        Score = 0;
    }

    /// <summary>
    /// HP�ɕύX��������
    /// </summary>
    /// <param name="value"></param>
    public void ChangeLife(int value)
    {
        Life += value;

        //HP��0�ȉ��ɂȂ�Ǝ��S���̊֐����Ă�
        if(Life <= 0)
        {
            Death();
        }
    }

    /// <summary>
    /// Score�ɕύX��������
    /// </summary>
    /// <param name="value"></param>
    public void ChangeScore(int value)
    {
        Score += value;
    }

    /// <summary>
    /// �v���C���[�����S�����Ƃ��̏���
    /// </summary>
    private void Death()
    {

    }
}
