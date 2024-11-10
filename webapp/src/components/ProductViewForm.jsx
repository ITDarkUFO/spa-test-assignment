import { Input, InputNumber, Form, Typography } from 'antd'

const { TextArea } = Input;

const ProductViewForm = ({ form }) => {
    const isFormReadOnly = true;

    return (
        <Form form={form} layout="vertical" className="modal-form">
            <Form.Item name="Name" label="Название товара">
                <TextArea readOnly={isFormReadOnly} size="large"></TextArea>
            </Form.Item>
            <Form.Item name="Description" label="Описание товара">
                <TextArea readOnly={isFormReadOnly} size="large" ></TextArea>
            </Form.Item>
            <Form.Item name="Vendorcode" label="Код товара">
                <InputNumber readOnly={isFormReadOnly} size="large" />
            </Form.Item>
            <Form.Item name="Quantity" label="Количество на складе">
                <InputNumber readOnly={isFormReadOnly} id="productQuantity" size="large" />
            </Form.Item>
            <Form.Item name="Price" label="Цена товара">
                <InputNumber readOnly={isFormReadOnly} size="large" />
            </Form.Item>
        </Form>
    );
};

export default ProductViewForm;