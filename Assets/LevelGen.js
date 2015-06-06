#pragma strict

public var available_blocks : GameObject[];

function Start () {
var num_blocks : int = 100;
    var n : int = 0;
    
    for(var i : int = 0; i < num_blocks; i++)
    {
       n = Random.Range(0, available_blocks.length);
       Instantiate(available_blocks[n], new Vector3(i*15, 4, 2),  Quaternion.identity );
       Debug.Log( "Random " + n + "  i=" + i);
    }

}

function Update () {
    
}