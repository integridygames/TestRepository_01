using UnityEngine;

public struct Hero
{
    private string _name;
    private float _health;
    private float _damage;

    public Hero(string heroName, float startHealth, float startDamage)
    {
        _name = heroName;
        _health = startHealth;
        _damage = startDamage;
    }

    public void Hello()
    {
        Debug.Log($"Познакомьтесь с героем {_name}. Его здоровье {_health}, его урон {_damage}");
    }

    public void Attack(Hero hero)
    {
        if (hero._name == _name)
        {
            Debug.Log("Некорректная атака. Герой не может атаковать сам себя.");
            return;
        }

        hero._health -= _damage;

        Debug.Log($"Герой {_name} атаковал героя {hero._name}. Нанесенный урон {_damage}. Оставшееся здоровье: {hero._health}");
    }
}