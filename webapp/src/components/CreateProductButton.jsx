import { Button } from 'antd'
import { PlusOutlined } from '@ant-design/icons';
import { useModal } from '../context/ModalContext';


const CreateProductButton = () => {
    const { setCreateModalVisible } = useModal();

    const handleClick = () => {
        console.debug("Запрос окна добавления товара");
        setCreateModalVisible(true);
    }

    return (
        <Button type="primary" size="large" icon={<PlusOutlined />} onClick={handleClick}>Добавить товар</Button>
    );
}

export default CreateProductButton;